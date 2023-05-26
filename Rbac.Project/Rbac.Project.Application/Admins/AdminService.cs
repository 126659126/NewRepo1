using Microsoft.EntityFrameworkCore;
using Rbac.Project.Application.Admins.Dto;
using Rbac.Project.Domain;
using Rbac.Project.Repositories;
using Rbac.Project.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rbac.Project.Application.Admins
{
    public class AdminService : IAdminService
    {
        private readonly IRepository<UserTable> repository;
        public AdminService(IRepository<UserTable> repository)
        {
            this.repository = repository;
        }


        public async Task<ResultDto<UserTable>> InsertAsync(CreateOrUpdateDto dto)
        {
            try
            {
                if (await repository.ExistsAsync(m => m.U_UserName == dto.U_UserName))
                {
                    return new ResultDto<UserTable> { Result = Result.Success, Message = "用户已存在" };
                }
                else
                {
                    dto.U_Password = dto.U_Password.Md5();

                    await repository.InsertAsync(new UserTable
                    {
                        U_UserName = dto.U_UserName,
                        U_Password = dto.U_Password,
                        U_Name = dto.U_Name,
                        U_Email = dto.U_Email,
                        Name = "张三",
                        AddTime = DateTime.Now,
                        U_Avatar = dto.U_Avatar,
                        U_Remark = dto.U_Remark
                    });

                    return new ResultDto<UserTable> { Result = Result.Success };
                }
            }
            catch (Exception e)
            {
                return new ResultDto<UserTable> { Result = Result.Failure, Message = e.Message };
            }
        }

        public async Task<ResultDto> LoginAsunc(LoginDto dto)
        {
            var admin = await repository.FindAsync(m => m.U_UserName == dto.UserName);

            if (admin == null)
            {
                return new ResultDto { Result = Result.Success, Message = "无此用户" };
            }
            else
            {
                if (admin.U_Password.ToUpper() == dto.Password.Md5().ToUpper())
                {
                    //生成Token
                    return new ResultDto { Result = Result.Success, Message = "登录成功" };
                }
                else
                {
                    return new ResultDto { Result = Result.Success, Message = "密码错误" };
                }
            }
        }

        public async Task<PageDto<List<UserTable>>> PageDataAsync(int PageIndex = 1, int pageSize = 2)
        {
            var list = repository.Queryable();

            return new PageDto<List<UserTable>>
            {
                Result = Result.Success,
                TotalCount = await list.CountAsync(),
                Data = await list.Skip((PageIndex - 1) * pageSize).Take(pageSize).ToListAsync()
            };
        }

        public async Task<ResultDto<Tuple<int, List<ListDto>>>> PageDataTupleAsync(QueryDto query, int PageIndex = 1, int pageSize = 2)
        {
            var list = repository.Queryable().Select(m => new ListDto
            {
                U_Id = m.U_Id,
                U_UserName = m.U_UserName,
                U_Name = m.U_Name,
                U_Email = m.U_Email,
                U_Avatar = m.U_Avatar,
                Name = m.Name,
                AddTime = m.AddTime
            });

            //拼接查询条件
            if (!string.IsNullOrEmpty(query.Keywords))
            {
                list = list.Where(m => m.U_UserName.StartsWith(query.Keywords) || m.Name.Contains(query.Keywords));
            }

            if (query.StartTime != null)
            {
                list = list.Where(m => m.AddTime >= query.StartTime);
            }

            if (query.StartTime != null)
            {
                list = list.Where(m => m.AddTime <= query.EndTime);
            }

            var pageDate = await list.Skip((PageIndex - 1) * pageSize).Take(pageSize).ToListAsync();

            Tuple<int, List<ListDto>> tuple = new Tuple<int, List<ListDto>>(item1: list.Count(), item2: pageDate);

            return new ResultDto<Tuple<int, List<ListDto>>> { Result = Result.Success, Data = tuple };
        }
    }
}

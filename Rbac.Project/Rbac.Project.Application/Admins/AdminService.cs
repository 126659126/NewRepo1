using Rbac.Project.Application.Admins.Dto;
using Rbac.Project.Domain;
using Rbac.Project.Repositories;
using Rbac.Project.Utility;
using System;
using System.Threading.Tasks;

namespace Rbac.Project.Application.Admins
{
    public class AdminService: IAdminService
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
                        Name="张三",
                        AddTime=DateTime.Now,
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
    }
}

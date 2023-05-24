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


        public async Task<UserTable> InsertAsync()
        {
            return await repository.InsertAsync(new UserTable
            {
                U_UserName = "张三",
                U_Password = "21232F297A57A5A743894A0E4A801FC3",
                U_Name = "张三",
                U_Email = "zhangsan@qq.com",
                Name = "Admin",
                AddTime = DateTime.Now
            });
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

using Rbac.Project.Application.Admins.Dto;
using Rbac.Project.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rbac.Project.Application.Admins
{
    public interface IAdminService
    {

        Task<ResultDto<UserTable>> InsertAsync(CreateOrUpdateDto dto);

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<ResultDto> LoginAsunc(LoginDto dto);
    }
}

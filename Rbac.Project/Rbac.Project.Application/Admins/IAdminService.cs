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

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        Task<PageDto<List<UserTable>>> PageDataAsync(int PageIndex = 1, int pageSize = 2);

        /// <summary>
        /// 分页(有条件)
        /// </summary>
        /// <param name="query"></param>
        /// <param name="PageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        Task<ResultDto<Tuple<int, List<ListDto>>>> PageDataTupleAsync(QueryDto query, int PageIndex = 1, int pageSize = 2);
    }
}

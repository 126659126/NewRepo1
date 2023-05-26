using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rbac.Project.Application;
using Rbac.Project.Application.Admins;
using Rbac.Project.Application.Admins.Dto;
using System.Threading.Tasks;

namespace Rbac.Project.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserTableController : ControllerBase
    {
        private readonly IAdminService adminService;
        public UserTableController(IAdminService _adminService)
        {
            this.adminService = _adminService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateOrUpdateDto dto)
        {
            return Ok(await adminService.InsertAsync(dto));
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> LoginAsunc(LoginDto dto)
        {
            return Ok(await adminService.LoginAsunc(dto));
        }

        /// <summary>
        /// 分页显示
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> PageData(int PageIndex = 1, int pageSize = 2)
        {
            return Ok(await adminService.PageDataAsync(PageIndex, pageSize));
        }

        /// <summary>
        /// 分页(有条件)
        /// </summary>
        /// <param name="query"></param>
        /// <param name="PageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns> 
        [HttpGet]
        public async Task<IActionResult> PageDataTupleAsync([FromQuery]QueryDto query, int PageIndex = 1, int pageSize = 2)
        {
            return Ok(await adminService.PageDataTupleAsync(query, PageIndex, pageSize));
        }
    }
}

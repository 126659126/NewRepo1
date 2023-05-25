﻿using Microsoft.AspNetCore.Http;
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
    }
}

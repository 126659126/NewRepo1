using IRepostitory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace Web522zuoye.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleRepostitory<Role_db> repostitory;
        public RoleController(IRoleRepostitory<Role_db> _repostitory)
        {
            this.repostitory = _repostitory;
        }


    }
}

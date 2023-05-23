using IRepostitory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace Web522zuoye.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepostitory<UserTable> repostitory;
        public UserController(IUserRepostitory<UserTable> _repostitory)
        {
            this.repostitory = _repostitory;
        }

        /// <summary>
        /// 增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPost]
        public IActionResult UserAdd(UserTable entity)
        {
            try
            {
                var list= repostitory.UserAdd(entity);
                return Ok(list);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// 删
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpDelete]
        public IActionResult UserDelete(UserTable entity)
        {
            try
            {
                var list = repostitory.UserDelete(entity);
                return Ok(list);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpPut]
        public IActionResult UserAlter(UserTable entity)
        {
            try
            {
                var list = repostitory.UserAlter(entity);
                return Ok(list);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// 查
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var list = repostitory.GetAll();
                return Ok(list);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="name">账号</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult LogIn(string name, string pwd)
        {
            try
            {
                var list = repostitory.LogIn(name,pwd);
                return Ok(list);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}

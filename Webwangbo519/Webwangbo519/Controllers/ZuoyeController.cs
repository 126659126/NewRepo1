using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Webwangbo519.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ZuoyeController : ControllerBase
    {
        [HttpGet]
        public IActionResult QueryShow()
        {
            string list = "这是string类型";//string
            bool list1 = true;//bool
            float flo1 =5;//单精度
            double dou1 = 5.43;//双精度
            
            //装箱
            int int1 = 100;
            object obj1 = int1;

            //拆箱
            int int2 = 100;
            object obj2 = int2;
            int num = (int)obj2;

            return Ok(new{ list, list1, flo1, dou1, obj1, num });
        }
    }
}

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Rbac.Project.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UploadFileController : ControllerBase
    {
        private readonly IWebHostEnvironment env;

        public UploadFileController(IWebHostEnvironment env)
        {
            this.env = env;
        }

        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            var dir = $"/UploadFiles/images/{DateTime.Now.ToString("yyyy")}/{DateTime.Now.ToString("MMdd")}/";
            if (!Directory.Exists($"{env.WebRootPath}{dir}"))
            {
                Directory.CreateDirectory($"{env.WebRootPath}{dir}");
            }

            Random random = new Random();

            var fileName = $"{dir}{DateTime.Now.ToString("yyyyMMddHHmmss")}-{random.Next(100, 999)}{Path.GetExtension(file.FileName)}";

            using (FileStream fileStream = new FileStream($"{env.WebRootPath}{fileName}", FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return Ok(fileName);
        }
    }
}

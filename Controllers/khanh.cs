using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QuanLiHocSinh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class khanh : ControllerBase
    {
        [HttpGet]
        public IActionResult get()
        {
            return Ok("");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Types.Hello> Get()
        {
            string text = HttpContext.Request.Query["text"].FirstOrDefault() ?? Types.Hello.DefaultText;
            return new Types.Hello(text);
        }

        [HttpGet("{text}")]
        public ActionResult<Types.Hello> Get(string text)
        {
            return new Types.Hello("Hello, " + text);
        }
    }
}
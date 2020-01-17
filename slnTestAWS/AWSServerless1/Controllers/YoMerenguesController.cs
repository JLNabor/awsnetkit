using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AWSServerless1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YoMerenguesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "hola guapisimo" };
        }
    }
}
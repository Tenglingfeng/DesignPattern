using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobRecruitment.Controllers
{
    /// <summary>
    ///测试接口
    /// </summary>
    [Route("[controller]/[action]")]
    //[ApiController]
    public class TestController : ControllerBase
    {
        /// <summary>
        ///返回string
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetString()
        {
            return "123";
        }
    }
}
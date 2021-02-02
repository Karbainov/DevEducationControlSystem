using DevEducationControlSystem.BLL;
using DevEducationControlSystem.BLL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.Security.Claims;

namespace DevEducationControlSystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var logicManager = new AuthorizationLogicManager();
            return Ok(logicManager.GetLoginPassworlRole());
        }

        //[HttpPut("{login/{pass}")]
        //public IActionResult Get(string login, string pass)
        //{
        //    var identity = GetIdentity(login, pass);
        //    return Ok();
        //}

        //private ClaimsIdentity GetIdentity(string login, string pass)
        //{
        //    var logicManager = new AuthorizationLogicManager();
        //    List<LoginPassRoleModel> list = logicManager.GetLoginPassworlRole();



        //    return new ClaimsIdentity();
        //}
    }
}

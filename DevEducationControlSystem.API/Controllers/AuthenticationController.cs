using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace DevEducationControlSystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController
    {
        //[HttpPut("{login/{pass}")]
        //public IActionResult Get(string login, string pass)
        //{
        //    var identity = GetIdentity(login, pass);
        //}

        //private ClaimsIdentity GetIdentity(string login, string pass)
        //{
        //    string role = "";
        //}
    }
}

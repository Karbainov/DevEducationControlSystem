using DevEducationControlSystem.BLL;
using DevEducationControlSystem.BLL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace DevEducationControlSystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : Controller
    {
        //[HttpGet("{login}")]
        //public IActionResult Get(string login)
        //{
        //    var logicManager = new AuthorizationLogicManager();
        //    return Ok(logicManager.GetLoginPassworlRole(login));
        //}

        [HttpGet("{login}/{pass}")]
        public IActionResult Get(string login, string pass)
        {
            var identity = GetIdentity(login, pass);
            if(identity == null)
            {
                return StatusCode(415,"Некорректно введен Логин или Пароль");
            }

            JwtSecurityToken token = new JwtSecurityToken
            (
                issuer: AuthenticationSettings.Issuer,
                audience: AuthenticationSettings.Audience,
                claims: identity.Claims,
                notBefore: DateTime.Now,
                expires: DateTime.Now.Add(TimeSpan.FromMinutes(AuthenticationSettings.Lifetime)),
                signingCredentials: new SigningCredentials(AuthenticationSettings.SecurityKey, SecurityAlgorithms.HmacSha384)
            );
            string handler = new JwtSecurityTokenHandler().WriteToken(token);
            return Ok(handler);
        }

        private ClaimsIdentity GetIdentity(string login, string pass)
        {
            var logicManager = new AuthorizationLogicManager();
            string role = "";
            List<LoginPassRoleModel> list = logicManager.GetLoginPassworlRole(login);

            foreach (var r in list)
            {
                if (login == r.UserLog && pass == r.UserPas)
                {
                    role = r.Roles[0].Name;
                }
            }
            
            if (role == "")
            {
                return null;
            }

            var claims = new List<Claim>()
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, login),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, role)
            };
            
            return new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
        }
    }
}

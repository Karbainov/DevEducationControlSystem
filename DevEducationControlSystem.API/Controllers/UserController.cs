using DevEducationControlSystem.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEducationControlSystem.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        //[HttpGet("Student/{userId}")]
        //public IActionResult UpdatePersonalData(int userId)
        //{
            
        //    return Ok(null);
        //}

        [HttpGet("Student/{userId}")]
        public IActionResult GetHomeworksWithStatus(int userId)
        {
            var userLogicManager = new UserLogicManager();
            return Ok(userLogicManager.GetHomeworksWithStatus(userId));
        }
    }
}

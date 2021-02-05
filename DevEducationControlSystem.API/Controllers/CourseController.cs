using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevEducationControlSystem.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevEducationControlSystem.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CourseController : Controller
    {
        [HttpGet("{courseId}/userinfo")]
        public IActionResult GetAllInfoUserOnTheCourseById(int courseId)
        {
            var allInfoUserOnTheCourseLogicManager = new AllInfoUserOnTheCourseLogicManager();
            return Ok(allInfoUserOnTheCourseLogicManager.GetInfoOfStudentsOnTheCourseById(courseId));
        }

        [HttpGet("groupinfo/{groupId}")]
        public IActionResult GetAllInfoGroupOnTheCourseById(int groupId)
        {
            var allInfoUserOnTheCourseLogicManager = new AllInfoUserOnTheCourseLogicManager();
            return Ok(allInfoUserOnTheCourseLogicManager.GetGroupInfoById(groupId));
        }
    }       
   
}

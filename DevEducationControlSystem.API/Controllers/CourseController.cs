using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevEducationControlSystem.API.InputModels;
using DevEducationControlSystem.BLL;
using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.CRUD;
using DevEducationControlSystem.DBL.DTO.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevEducationControlSystem.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CourseController : Controller
    {
        //[Authorize]
        [HttpPost("CreateCourse/")]
        public IActionResult CreateCourse([FromBody]NewCourseInputModel inputModel)
        {
            var courseManager = new CourseManager();
            var id = courseManager.AddReturnId(inputModel.Name, inputModel.Description, inputModel.DurationInWeeks);

            return Ok(id);
        }

       [HttpPut("UpdateCourse/{courseId}")]
        public IActionResult UpdateCourseReturnId([FromBody]NewCourseInputModel inputModel, int courseId)
        {
            var courseManager = new CourseManager();
            var id = courseManager.UpdateReturnId(courseId, inputModel.Name, inputModel.Description, inputModel.DurationInWeeks);

            return Ok(id);
        }

        [HttpDelete("DeleteCourse/{courseId}")]
        public IActionResult DeleteCourse(int courseId)
        {
            var courseManager = new CourseManager();
            courseManager.DeleteReturnId(courseId);

            return Ok(courseManager);
        }
 
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

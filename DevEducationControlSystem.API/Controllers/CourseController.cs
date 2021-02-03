using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevEducationControlSystem.API.InputModels;
using DevEducationControlSystem.BLL;
using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.CRUD;
using DevEducationControlSystem.DBL.DTO.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevEducationControlSystem.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        [HttpPost("CreateCourse")]
        public IActionResult CreateCourse(NewCourseInputModel inputModel)
        {
            var courseManager = new CourseManager();
            courseManager.Add(inputModel.Name, inputModel.Description, inputModel.DurationInWeeks);

            return Ok(courseManager);
        }

        [HttpPut("UpdateCourse/{courseid}/{isDeleted}")]
        public IActionResult UpdateCourse(NewCourseInputModel inputModel, int courseid, int isDeleted)
        {
            var courseManager = new CourseManager();
            courseManager.Update(courseid, inputModel.Name, inputModel.Description, inputModel.DurationInWeeks, Convert.ToBoolean(isDeleted));

            return Ok(courseManager);
        }

        [HttpPost("DeleteCourse/{courseid}")]
        public IActionResult DeleteCourse(int courseid)
        {
            var courseManager = new CourseManager();
            courseManager.Delete(courseid);

            return Ok(courseManager);
        }
    }
}

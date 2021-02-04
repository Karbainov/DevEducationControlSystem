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
    public class CourseController : ControllerBase
    {
        [Authorize]
        [HttpPost("CreateCourse")]
        public IActionResult CreateCourse(NewCourseInputModel inputModel)
        {
            var courseManager = new CourseManager();
            string result = courseManager.AddReturnResult(inputModel.Name, inputModel.Description, inputModel.DurationInWeeks);

            return Ok(result);
        }

        [HttpPut("UpdateCourse/{courseId}/{isDeleted}")]
        public IActionResult UpdateCourse(NewCourseInputModel inputModel, int courseId, int isDeleted)
        {
            var courseManager = new CourseManager();
            var result = courseManager.UpdateReturnResult(courseId, inputModel.Name, inputModel.Description, inputModel.DurationInWeeks, Convert.ToBoolean(isDeleted));

            return Ok(result);
        }

        [HttpPost("DeleteCourse/{courseId}")]
        public IActionResult DeleteCourse(int courseId, string courseName)
        {
            var courseManager = new CourseManager();
            var result = courseManager.DeleteReturnResult(courseId, courseName);

            return Ok(result);
        }

        [HttpPost("CreateHomeworkByCourse/{courseId}")]
        public IActionResult CreateHomeworkCourse(int courseId, NewHomeworkCourseInputModel inputModel, ResourceInputModel resource)
        {
            var homeworkManager = new HomeworkManager();
            var resourceManager = new ResourceManager();
            var result = homeworkManager.AddReturnResult(inputModel.ResourceId, inputModel.Name, inputModel.Description, inputModel.IsSolutionRequired);

            return Ok(result);
        }

        [HttpPost("DeleteHomeworkByCourse/{homeworkId}")]
        public IActionResult DeleteHomeworkCourse(int homeworkId, string name)
        {
            var homeworkManager = new HomeworkManager();
            var result = homeworkManager.DeleteReturnResult(homeworkId, name);
            return Ok(result);
        }

        [HttpPost("UpdateHomeworkByCourse/{homeworkId}")]
        public IActionResult UpdateHomeworkCourse(int homeworkId, NewHomeworkCourseInputModel inputModel)
        {
            var homeworkManager = new HomeworkManager();
            var result = homeworkManager.UpdateReturnResult(homeworkId, inputModel.ResourceId, inputModel.Name, inputModel.Description, inputModel.IsDeleted, inputModel.IsSolutionRequired);
            return Ok(result);
        }

        //Добавить/удалить/редактировать материалы курса
        [HttpPost("MaterialkByCourse/{materialId}")]
        public IActionResult AddMaterialCourse()
        {
            return Ok();
        }
    }
}

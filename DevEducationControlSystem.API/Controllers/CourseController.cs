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

/*        [HttpPut("UpdateCourse/{courseId}/{isDeleted}")]
        public IActionResult UpdateCourse(NewCourseInputModel inputModel, int courseId, int isDeleted)
        {
            var courseManager = new CourseManager();
            var id = courseManager.UpdateCourse(courseId, inputModel.Name, inputModel.Description, inputModel.DurationInWeeks, Convert.ToBoolean(isDeleted));

            return Ok(id);
        }

        [HttpPost("DeleteCourse/{courseId}/{courseName}")]
        public IActionResult DeleteCourse(int courseId)
        {
            var courseManager = new CourseManager();
            var id = courseManager.DeleteReturnId(courseId);

            return Ok(courseManager);
        }*/

/*        [HttpPost("CreateHomeworkByCourse/{courseId}")]
        public IActionResult CreateHomeworkCourse(int courseId, NewHomeworkCourseInputModel inputModel)
        {
            var homeworkManager = new HomeworkManager();
            var result = homeworkManager.AddReturnResult(inputModel.ResourceId, inputModel.Name, inputModel.Description, inputModel.IsSolutionRequired);

            return Ok(result);
        }*/

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevEducationControlSystem.API.InputModels;
using DevEducationControlSystem.BLL;
using DevEducationControlSystem.BLL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevEducationControlSystem.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeworkController : Controller
    {
        [HttpPost("Appoint")]
        public IActionResult AppointHomeworkToGroup(HomeworkAppointmentInputModel inputModel)
        {
            var homeworkLogicManager = new HomeworkLogicManager();
            try
            {
                homeworkLogicManager.AppointHomeworkToGroup(new HomeworkAppointmentModel()
                {
                    HomeworkId = inputModel.HomeworkId,
                    GroupId = inputModel.GroupId,
                    StartDate = inputModel.StartDate,
                    DeadLine = inputModel.DeadLine
                });
            } catch (ArgumentException e)
            {
                return StatusCode(404, e.Message);
            }
            return Ok();
        }

        [HttpGet("Answers/{homeworkId}/{groupId}")]
        public IActionResult SelectAllAnswersByHomeworkIdAndGroupId(int homeworkId, int groupId)
        {
            var homeworkLogicManager = new HomeworkLogicManager();
            try
            {
               return Ok( homeworkLogicManager.SelectAllAnswersByHomeworkIdAndGroupId(homeworkId,groupId));
            }
            catch (ArgumentException e)
            {
                return StatusCode(404, e.Message);
            }
        }
    }
}

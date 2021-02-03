using DevEducationControlSystem.BLL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEducationControlSystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatisticController: Controller
    {
        [HttpGet("Teachers")]
        public IActionResult GetNumberOfTeachersByCourseId()
        {
            var statisticLogic = new StatisticLogicManager();
            return Ok(statisticLogic.GetNumberOfTeachers());
        }

        [HttpGet("TeachersStatistic")]
        public IActionResult GetTeachersStatisticByCourseId(int courseId)
        {
            //courseId = 1;
            var statisticLogic = new StatisticLogicManager();
            return Ok(statisticLogic.GetNumberOfTeachersByCourseId(courseId));
        }

        [HttpGet("Roles")]
        public IActionResult GetGroupInfoById()
        {
            var StatisticLogicManager = new StatisticLogicManager();
            return Ok(StatisticLogicManager.GetRoleStatistic());
        }
    }
}
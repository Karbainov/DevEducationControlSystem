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

        [HttpGet("Cities")]
        public IActionResult GetNumberOfUsersWithStatusInCourseInCity()
        {
            var statisticLogic = new StatisticLogicManager();
            var nn = statisticLogic.GetNumberOfUsersWithStatusInCourseInCity();
            return Ok(nn);
        }

        [HttpGet("Roles")]
        public IActionResult GetGroupInfoById()
        {
            var StatisticLogicManager = new StatisticLogicManager();
            return Ok(StatisticLogicManager.GetRoleStatistic());
        }

        [HttpGet("StudentsOnCourseByGroups/{CourseId}")]
        public IActionResult CountStudentsOnCourseByGroup(int CourseId)
        {
            var statisticLogic = new StatisticLogicManager();
            return Ok(statisticLogic.NumberOfStudentsOnCourseByGroups(CourseId));
        }
    }
}
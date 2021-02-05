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

        [HttpGet("Roles")]
        public IActionResult GetGroupInfoById()
        {
            var StatisticLogicManager = new StatisticLogicManager();
            return Ok(StatisticLogicManager.GetRoleStatistic());
        }

        [HttpGet("Roles")]
        public IActionResult GetGroupInfoById()
        {
            var statisticLogic = new StatisticLogicManager();
            List<countHomeworkByThemeInCityCourseGroup> countHomeworkByThemeInCityCourseGroup = new List<countHomeworkByThemeInCityCourseGroup>;
            countHomeworkByThemeInCityCourseGroup = statisticLogic.CountHomeworkByThemeInCityCourseGroup();
            return Ok(countHomeworkByThemeInCityCourseGroup);
        }
    
    }
}
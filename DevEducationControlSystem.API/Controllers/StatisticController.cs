using DevEducationControlSystem.BLL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DevEducationControlSystem.DBL.DTO.StatisticsForMethodist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevEducationControlSystem.DBL;

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
            var getNumberOfUsersWithStatusInCourseInCityResult = statisticLogic.GetNumberOfUsersWithStatusInCourseInCity();
            return Ok(getNumberOfUsersWithStatusInCourseInCityResult);
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

        [Authorize(Roles = "Методист")]
        [HttpGet("CountHomeworkByThemeInCityCourseGroup")]
        public IActionResult CountHomeworkByThemeInCityCourseGroup()
        {
            var statisticManager = new StatisticManager();
            List<CountHomeworkByThemeInCityCourseGroupDTO> countHomeworkByThemeInCityCourseGroup = new List<CountHomeworkByThemeInCityCourseGroupDTO>();
            countHomeworkByThemeInCityCourseGroup = statisticManager.CountHomeworkByThemeInCityCourseGroup();
            return Ok(countHomeworkByThemeInCityCourseGroup);

        }

        [Authorize(Roles = "Методист")]
        [HttpGet("StudentsStudyingAfterBase")]
        public IActionResult StudentsStudyingAfterBase()
        {
            var statisticManager = new StatisticManager();
            List<StudentsStudyingAfterBaseDTO> studentsStudyingAfterBase = new List<StudentsStudyingAfterBaseDTO>();
            studentsStudyingAfterBase = statisticManager.StudentsStudyingAfterBase();
            return Ok(studentsStudyingAfterBase);
        }
    } 

}
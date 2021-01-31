using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevEducationControlSystem.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DevEducationControlSystem.API.InputModels;

namespace DevEducationControlSystem.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GroupController : Controller
    {

        [HttpGet("Teacher/{groupId}")]
        public IActionResult GetGroupInfoById(int groupId)
        {
            var groupLogicManager = new GroupLogicManager();
            return Ok(groupLogicManager.GetGroupInfoById(groupId));
        }

        [HttpGet("Student/{userId}/private")]
        public IActionResult GetStudentUnlockedData(int userId)
        {
            var groupLogicManager = new GroupLogicManager();
            return Ok(groupLogicManager.GetPrivateStudentMainPageModel(userId));
        }
        [HttpPut("Student/{userId}/private")]
        public IActionResult AddFeedback(NewFeedbackInputModel feedback, int userId)
        {
            var groupAPIManager = new GroupAPIManager();
            return Ok(groupAPIManager.AddAndCheckNewFeedback(feedback, userId));
        }
        [HttpGet("User/{userId}/Materials/{tag}")]
        public IActionResult GetStudentUnlockedDataByTag(int userId, string tag)
        {
            var groupLogicManager = new GroupLogicManager();
            return Ok(groupLogicManager.GetStudentUnlockedMaterialsByTag(userId, tag));
        }

        [HttpGet("Attendance/{groupId}")]
        public IActionResult GetGroupAttendanceById(int groupId)
        {
            var groupLogicManager = new GroupLogicManager();
            return Ok(groupLogicManager.GetGroupAttendanceById(groupId));
        }
    }
}

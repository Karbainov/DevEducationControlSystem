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

        [HttpPut("Lesson")]
        public IActionResult AddLessonWithAttendances(LessonInputModel lesson)
        {
            var groupLogicManager = new GroupLogicManager();
            var lessonModel = new LessonModel() { GroupId = lesson.GroupId, Name = lesson.Name, LessonDate = lesson.LessonDate, Comments = lesson.Comments };
            groupLogicManager.AddLessonWithAttendances(lessonModel);
            return Ok();
        }

        [HttpPost("Attendance")]
        public IActionResult UpdateAttendance(int attendanceId, bool isPresent)
        {
            var groupLogicManager = new GroupLogicManager();
            groupLogicManager.UpdateAttendance(attendanceId, isPresent);
            return Ok();
        }
    }
}

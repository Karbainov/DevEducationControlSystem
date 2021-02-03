using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevEducationControlSystem.API.InputModels;
using DevEducationControlSystem.BLL;
using DevEducationControlSystem.BLL.Models;
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

        [HttpGet("Teacher/{groupId}")]
        public IActionResult GetGroupInfoById(int groupId)
        {
            var groupLogicManager = new GroupLogicManager();
            return Ok(groupLogicManager.GetGroupInfoById(groupId));
        }

        [HttpGet("Payment/{groupId}")]
        public IActionResult GetPaymentInfoById(int groupId)
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
        public IActionResult AddFeedback(List<NewFeedbackInputModel> feedback, int userId)
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

        [HttpPut("Lesson/{groupId}")]
        public IActionResult AddLessonWithAttendances(LessonInputModel lesson, int groupId)
        {
            if(groupId != lesson.GroupId)
            {
                return StatusCode(415);
            }
            var groupLogicManager = new GroupLogicManager();
            var lessonModel = new LessonModel() { GroupId = lesson.GroupId, Name = lesson.Name, LessonDate = lesson.LessonDate, Comments = lesson.Comments };
            try
            {
                return Ok(groupLogicManager.AddLessonWithAttendances(lessonModel));
            }
            catch (ArgumentException e)
            {
                return StatusCode(404, e.Message);
            }
        }

        [HttpPost("Attendance")]
        public IActionResult UpdateAttendance(int attendanceId, bool isPresent)
        {
            var groupLogicManager = new GroupLogicManager();
            groupLogicManager.UpdateAttendance(attendanceId, isPresent);
            return Ok();
        }

        [HttpPut("Attendance")]
        public IActionResult AddAttendance(int userId,int lessonId, bool isPresent)
        {
            var groupLogicManager = new GroupLogicManager();            
            return Ok(groupLogicManager.AddAttendance(userId, lessonId, isPresent));
        }
    [HttpGet("Students/{groupId}")]
    public IActionResult GetStudentsByGroupId(int groupId)
    {
      var groupLogicManager = new GroupLogicManager();
      return Ok(groupLogicManager.GetStudentsByGroupId(groupId));
    }

    [HttpGet("PassedHomeworkThemeAnswer/{studentId}")]
    public IActionResult GetPassedThemesAndHomeworksAndAnswerModelByGroupId(int studentId)
    {
      var groupLogicManager = new GroupLogicManager();
      return Ok(groupLogicManager.GetPassedThemesAndHomeworksAndAnswerModelByGroupId(studentId));
    }
    [HttpGet("StudentAnswerStoryAndComment/{userid}/{homeworkId}")]
    public IActionResult GetStudentAnswerStoryAndCommentByUserIdandByHomeworkid( int userid, int homeworkId)
    {
      var groupLogicManager = new GroupLogicManager();
      return Ok(groupLogicManager.GetStudentAnswerStoryAndCommentById( userid, homeworkId));
    }
  }
}

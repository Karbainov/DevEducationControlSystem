using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevEducationControlSystem.BLL;
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

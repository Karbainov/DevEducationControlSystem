﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevEducationControlSystem.API.InputModels;
using DevEducationControlSystem.BLL;
using DevEducationControlSystem.BLL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DevEducationControlSystem.API.InputModels;
using Microsoft.AspNetCore.Authorization;

using Microsoft.AspNetCore.Authorization;

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

        [HttpGet("Payment/{groupId}")]
        public IActionResult GetPaymentInfoById(int groupId)
        {
            var groupLogicManager = new GroupLogicManager();
            return Ok(groupLogicManager.GetGroupInfoById(groupId));
        }

        [Authorize(Roles = "Студент")]
        [HttpGet("Student/{userId}/private")]
        public IActionResult GetStudentUnlockedData(int userId)
        {
            if (IdRevieser.RevieseId(User.Identity.Name, userId) == true)
            {
                var groupLogicManager = new GroupLogicManager();
                return Ok(groupLogicManager.GetPrivateStudentMainPageModel(userId));
            }
            else
            {
                return BadRequest("Доступ ограничен");
            }
            
        }

        [Authorize(Roles = "Студент")]
        [HttpPut("Student/{userId}/private")]
        public IActionResult AddFeedback(List<FeedbackInputModel> feedback, int userId)
        {            if (IdRevieser.RevieseId(User.Identity.Name, userId) == true)
            {
                new GroupAPIManager().AddAndCheckNewFeedback(feedback, userId);
                var groupLogicManager = new GroupLogicManager();
                return Ok(groupLogicManager.GetPrivateStudentMainPageModel(userId));
            }
            else
            {
                return BadRequest("Доступ ограничен");
            }
        }
        [Authorize(Roles = "Студент")]
        [HttpDelete("Student/{userId}/private")]
        public IActionResult DeleteFeedback(List<FeedbackInputModel> feedback, int userId)
        {
            if (IdRevieser.RevieseId(User.Identity.Name, userId) == true)
            {
                new GroupAPIManager().DeleteAndCheckFeedback(feedback, userId);
                var groupLogicManager = new GroupLogicManager();
                return Ok(groupLogicManager.GetPrivateStudentMainPageModel(userId));
            }
            else
            {
                return BadRequest("Доступ ограничен");
            }
        }

        [Authorize(Roles = "Студент")]
        [HttpGet("User/{userId}/Materials/{tag}")]
        public IActionResult GetStudentUnlockedDataByTag(int userId, string tag)
        {
            if (IdRevieser.RevieseId(User.Identity.Name, userId) == true)
            {
                var groupLogicManager = new GroupLogicManager();
                return Ok(groupLogicManager.GetStudentUnlockedMaterialsByTag(userId, tag));
            }
            else
            {
                return BadRequest("Доступ ограничен");
            }
        }

        [Authorize(Roles = "Преподаватель")]
        [HttpGet("Attendance/{groupId}")]
        public IActionResult GetGroupAttendanceById(int groupId)
        {
            var groupLogicManager = new GroupLogicManager();
            try
            {
                return Ok(groupLogicManager.GetGroupAttendanceById(User.Identity.Name ,groupId));
            }
            catch (ArgumentException e)
            {
                return StatusCode(404, e.Message);
            }
            catch(UnauthorizedAccessException e)
            {
                return StatusCode(403, e.Message);
            }
        }


        [Authorize(Roles = "Преподаватель")]
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
                return Ok(groupLogicManager.AddLessonWithAttendances(User.Identity.Name, lessonModel));
            }
            catch (ArgumentException e)
            {
                return StatusCode(404, e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                return StatusCode(403, e.Message);
            }
        }

        [Authorize(Roles = "Преподаватель")]
        [HttpPost("Attendance")]
        public IActionResult UpdateAttendance(int attendanceId, bool isPresent)
        {
            var groupLogicManager = new GroupLogicManager();
            groupLogicManager.UpdateAttendance(attendanceId, isPresent);
            return Ok();
        }

        [Authorize(Roles = "Преподаватель")]
        [HttpPut("Attendance")]
        public IActionResult AddAttendance(int userId,int lessonId, bool isPresent)
        {
            var groupLogicManager = new GroupLogicManager();            
            return Ok(groupLogicManager.AddAttendance(userId, lessonId, isPresent));
        }
    }
}

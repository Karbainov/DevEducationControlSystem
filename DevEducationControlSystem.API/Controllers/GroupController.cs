﻿using System;
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

        [HttpGet("User/{userId}/Materials")]
        public IActionResult GetStudentAllowedData(int userId)
        {
            var groupLogicManager = new GroupLogicManager();
            return Ok(groupLogicManager.GetStudentUnlockedData(userId));
        }

    }
}

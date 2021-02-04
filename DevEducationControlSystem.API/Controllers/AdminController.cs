﻿using DevEducationControlSystem.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEducationControlSystem.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AdminController : Controller
    {
        [HttpGet("RecycleBin")]
        public IActionResult GetAllSoftDeletedItems()
        {
            var adminLogic = new AdminLogicManager();
            return Ok(adminLogic.GetSoftDeletedItems());
        }

        [HttpPut("RecycleBin/Homework")]
        public IActionResult RecoverHomeworkById(int homeworkId)
        {
            var adminLogicManager = new AdminLogicManager();
            adminLogicManager.RecoverHomeworkById(homeworkId);
            return Ok("Homework recovered");
        }

        [HttpDelete("RecycleBin/Homework")]
        public IActionResult HardDeleteHomeworkById(int homeworkId)
        {
            var adminLogicManager = new AdminLogicManager();
            adminLogicManager.HardDelHomeworkById(homeworkId);
            return Ok("Homework completly deleted");
        }

        [HttpPut("RecycleBin/Material")]
        public IActionResult RecoverMaterialById(int materialId)
        {
            var adminLogicManager = new AdminLogicManager();
            adminLogicManager.RecoverMaterialById(materialId);
            return Ok("Material recovered");
        }

        [HttpDelete("RecycleBin/Material")]
        public IActionResult HardDeleteMaterialById(int materialId)
        {
            var adminLogicManager = new AdminLogicManager();
            adminLogicManager.HardDelMaterialById(materialId);
            return Ok("Material completly deleted");
        }

        [HttpPut("RecycleBin/Course")]
        public IActionResult RecoverCourseById(int courseId)
        {
            var adminLogicManager = new AdminLogicManager();
            adminLogicManager.RecoverCourseById(courseId);
            return Ok("Course recovered");
        }

        [HttpDelete("RecycleBin/Course")]
        public IActionResult HardDeleteCourseById(int courseId)
        {
            var adminLogicManager = new AdminLogicManager();
            adminLogicManager.HardDelCourseById(courseId);
            return Ok("Course completly deleted");
        }
    }
}

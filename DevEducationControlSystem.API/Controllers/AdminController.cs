using DevEducationControlSystem.BLL;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Roles = "Администратор")]
        [HttpGet("RecycleBin")]
        public IActionResult GetAllSoftDeletedItems()
        {
            var adminLogic = new AdminLogicManager();
            return Ok(adminLogic.GetSoftDeletedItems());
        }

        [Authorize(Roles = "Администратор")]
        [HttpPut("RecycleBin/Homework")]
        public IActionResult RecoverHomeworkById(int homeworkId)
        {
            var adminLogicManager = new AdminLogicManager();
            adminLogicManager.RecoverHomeworkById(homeworkId);
            return Ok("Homework recovered");
        }

        [Authorize(Roles = "Администратор")]
        [HttpDelete("RecycleBin/Homework")]
        public IActionResult HardDeleteHomeworkById(int homeworkId)
        {
            var adminLogicManager = new AdminLogicManager();
            adminLogicManager.HardDelHomeworkById(homeworkId);
            return Ok("Homework completly deleted");
        }

        [Authorize(Roles = "Администратор")]
        [HttpPut("RecycleBin/Material")]
        public IActionResult RecoverMaterialById(int materialId)
        {
            var adminLogicManager = new AdminLogicManager();
            adminLogicManager.RecoverMaterialById(materialId);
            return Ok("Material recovered");
        }

        [Authorize(Roles = "Администратор")]
        [HttpDelete("RecycleBin/Material")]
        public IActionResult HardDeleteMaterialById(int materialId)
        {
            var adminLogicManager = new AdminLogicManager();
            adminLogicManager.HardDelMaterialById(materialId);
            return Ok("Material completly deleted");
        }

        [Authorize(Roles = "Администратор")]
        [HttpPut("RecycleBin/Course")]
        public IActionResult RecoverCourseById(int courseId)
        {
            var adminLogicManager = new AdminLogicManager();
            adminLogicManager.RecoverCourseById(courseId);
            return Ok("Course recovered");
        }

        [Authorize(Roles = "Администратор")]
        [HttpDelete("RecycleBin/Course")]
        public IActionResult HardDeleteCourseById(int courseId)
        {
            var adminLogicManager = new AdminLogicManager();
            adminLogicManager.HardDelCourseById(courseId);
            return Ok("Course completly deleted");
        }
    }
}

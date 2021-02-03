using DevEducationControlSystem.BLL;
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

        [HttpPost("RecycleBin/Homework")]
        public IActionResult RecoverHomeworkById(int homeworkId)
        {
            var adminLogicManager = new AdminLogicManager();
            adminLogicManager.RecoverHomeworkById(homeworkId);
            return Ok("Homework recovered");
        }

        [HttpPost("RecycleBin/Material")]
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
            adminLogicManager.HardDelete(materialId);
            return Ok("Material recovered");
        }

        [HttpPost("RecycleBin/Course")]
        public IActionResult RecoverCourseById(int courseId)
        {
            var adminLogicManager = new AdminLogicManager();
            adminLogicManager.RecoverCourseById(courseId);
            return Ok("Course recovered");
        }


    }
}

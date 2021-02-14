using DevEducationControlSystem.API.InputModels;
using DevEducationControlSystem.DBL.CRUD;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEducationControlSystem.API.Controllers
{
    public class MaterialController : Controller
    {
        //[Athtorise (Roles = "Методист")]
        [HttpPost("CreateMaterialkByCourse/{courseId}/{themeId}")]
        public IActionResult AddMaterialAndTagAndResourceByCourse([FromBody] MaterialAndTagByCourseInputModel inputModel, int courseId, int themeId)
        {
            var materialManager = new MaterialManager();
            var courseThemeManager = new Course_MaterialManager();
            var resourceManager = new ResourceManager();

            materialManager.Add(inputModel.Name);
            courseThemeManager.Add(courseId, themeId);
            resourceManager.Add(inputModel.ResourceLinks, inputModel.ResourceImage);

            return Ok();
        }

        //[Athtorise (Roles = "Методист")]
        [HttpPost("UpdateMaterialkByCourse/{materialId}/{courseId}")]
        public IActionResult UpdateMaterialCourse([FromRoute] int courseId, int materialId, MaterialAndTagByCourseInputModel inputModel)
        {
            var materialManager = new MaterialManager();
            var resourceManager = new ResourceManager();

            materialManager.Update(materialId, inputModel.Name);
            resourceManager.Update(courseId);

            return Ok();
        }

        //[Athtorise (Roles = "Методист")]
        [HttpPost("DeleteMaterialkByCourse/{materialId}/{courseId}")]
        public IActionResult DeleteMaterialCourse([FromRoute] int courseId, int materialId, int resourceId)
        {
            var materialManager = new MaterialManager();
            var courseThemeManager = new Course_MaterialManager();
            var resourceManager = new ResourceManager();

            materialManager.SoftDelete(materialId);
            //courseThemeManager.SoftDelete(courseId);
            //resourceManager.SoftDelete(resourceId);

            return Ok();
        }
    }
}

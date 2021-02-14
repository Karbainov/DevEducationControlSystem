using DevEducationControlSystem.API.InputModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevEducationControlSystem.DBL.CRUD;
using Microsoft.AspNetCore.Authorization;

namespace DevEducationControlSystem.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ThemeController : ControllerBase
    {
        [HttpGet("CreateTheme/{themeId}")]
        public IActionResult CreateTheme(NewThemeInputModel themeInputModel)
        {
            var themeManager = new ThemeManager();
            themeManager.Add(themeInputModel.Name);

            return Ok(themeManager);
        }

        [HttpPut("UpdateTheme/{themeId}/{isDeleted}")]
        public IActionResult UpdateTheme(int themeId, string name)
        {
            var themeManager = new ThemeManager();
            themeManager.Update(themeId, name);

            return Ok(themeManager);
        }

        [HttpDelete("DeleteTheme/{themeId}")]
        public IActionResult DeleteTheme(int themeId)
        {
            var themeManager = new ThemeManager();
            themeManager.Delete(themeId);

            return Ok(themeManager);
        }

        [HttpPut("SetThemeCourse/{themeId}/{courseId}")]
        public IActionResult SetThemeCourse(int themeId, int courseId)
        {
            var courseThemeManager = new Course_ThemeManager();
            courseThemeManager.Add(courseId, themeId);
            return Ok();
        }
    }
}

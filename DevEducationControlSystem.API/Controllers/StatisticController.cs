using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEducationControlSystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatisticController: Controller
    {
        [HttpGet]
        public IActionResult GetNumberOfTeachersByCourseId(int courseId)
        {

            return Ok();
        }
    }
}

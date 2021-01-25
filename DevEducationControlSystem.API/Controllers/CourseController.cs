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
    public class CourseController : ControllerBase
    {
        [HttpGet("{courseId}")]
        public IActionResult GetCourseInfoAndFeedbacksById(int courseId)
        {
            CoursePlusFeedbacksMapper feedbacksMapper = new CoursePlusFeedbacksMapper();
            return new OkObjectResult(feedbacksMapper.GetCourseInfoAndFeedbacksByCourseId(courseId));
        }
    }
}

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
            var model = feedbacksMapper.GetCourseInfoAndFeedbacksByCourseId(courseId);

            string a = model.CourseDTO.Name
                     + model.CourseDTO.Description
                     + '\n' + model.WholeCourseFeedbackDTO[0].ToString()
                     + '\n' + model.WholeCourseFeedbackDTO[1].ToString()
                     + '\n' + model.WholeCourseFeedbackDTO[2].ToString();

            return new OkObjectResult(a);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class CourseInCurrentCityDTO
    {
        public int CourseId { get; set; }
        public string Course { get; set; }
        public CourseInCurrentCityDTO()
        {

        }
        public CourseInCurrentCityDTO(int courseId, string course)
        {
            CourseId = courseId;
            Course = course;
        }
    }
}

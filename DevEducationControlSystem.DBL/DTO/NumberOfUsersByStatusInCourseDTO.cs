using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class NumberOfUsersByStatusInCourseDTO
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public List<NumberOfUsersByStatusDTO> NumberOfUsersByStatus { get; set; }
    }
}

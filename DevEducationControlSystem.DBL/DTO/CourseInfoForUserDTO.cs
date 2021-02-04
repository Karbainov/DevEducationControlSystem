using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class CourseInfoForUserDTO
    {
        public int CourseId { get; set; }
        public string Course { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public int DurationInWeeks { get; set; }
        public DateTime EndDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class GroupWithCityAndStatusAndCourseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }

        public int StatusId { get; set; }
        public string Status { get; set; }

        public int CityId { get; set; }
        public string City { get; set; }

        public int CourseId { get; set; }
        public string Course { get; set; }
    }
}

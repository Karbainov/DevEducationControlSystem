using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class NumberOfUsersWithStatusInCourseInCityDTO
    {
        public int CityId { get; set; } 
        public string CityName {get; set;}

        public List<NumberOfUsersByStatusInCourseDTO> NumberOfUsersByStatusInCourse { get; set; }

    }
}

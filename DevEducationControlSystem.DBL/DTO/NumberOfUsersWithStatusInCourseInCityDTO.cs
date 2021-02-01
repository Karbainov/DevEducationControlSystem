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

        //public int CourseId {get; set;} 
        //public string CourseName {get; set;}
        //List<NumberOfUsersByStatusDTO> NumberOfUsersByStatus;
        //public int StatusId {get; set;} 
        //public string Status {get; set;} 
        //public int UserCount {get; set;}
    }
}

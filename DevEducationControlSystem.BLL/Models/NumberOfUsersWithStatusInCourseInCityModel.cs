using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class NumberOfUsersWithStatusInCourseInCityModel
    {

        public int CityId { get; set; }
        public string CityName { get; set; }

        public List<NumberOfUsersByStatusInCourseModel> NumberOfUsersByStatusInCourse { get; set; }

        public NumberOfUsersWithStatusInCourseInCityModel()
        {

        }

        //public NumberOfUsersWithStatusInCourseInCityModel(NumberOfUsersWithStatusInCourseInCityDTO dto)
        //{
        //    CityId = dto.CityId;
        //    CityName = dto.CityName;
        //    // ??? List<NumberOfUsersByStatusInCourseModel> NumberOfUsersByStatusInCourse 

        //}
    }
}

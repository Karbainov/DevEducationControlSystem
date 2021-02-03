using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class CityByCurrentCourseDTO
    {
        public int CityId { get; set; }
        public string City { get; set; }
        public CityByCurrentCourseDTO()
        {

        }
        public CityByCurrentCourseDTO(int cityId, string city)
        {
            CityId = cityId;
            City = city;
        }
    }
}

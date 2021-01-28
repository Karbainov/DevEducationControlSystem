using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class NumberOfTeachersByCourseDTO
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int Amount { get; set; }

        public NumberOfTeachersByCourseDTO()
        {

        }

        public NumberOfTeachersByCourseDTO(NumberOfTeachersByCourseDTO dto)
        {
            CourseId = dto.CourseId;
            CourseName = dto.CourseName;
            CityId = dto.CityId;
            CityName = dto.CityName;
            Amount = dto.Amount;
        }
    }
}

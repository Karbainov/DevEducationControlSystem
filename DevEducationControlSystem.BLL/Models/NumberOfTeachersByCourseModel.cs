using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class NumberOfTeachersByCourseModel
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int Amount { get; set; }

        public NumberOfTeachersByCourseModel()
        {

        }

        public NumberOfTeachersByCourseModel(NumberOfTeachersByCourseDTO dto)
        {
            CourseId = dto.CourseId;
            CourseName = dto.CourseName;
            CityId = dto.CityId;
            CityName = dto.CityName;
            Amount = dto.Amount;
        }
    }
}

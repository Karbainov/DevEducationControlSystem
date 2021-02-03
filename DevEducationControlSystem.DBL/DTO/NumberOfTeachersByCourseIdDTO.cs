using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class NumberOfTeachersByCourseIdDTO
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int Amount { get; set; }
        public List<TeacherOnCourseDTO> TeachersList { get; set; }

        public NumberOfTeachersByCourseIdDTO()
        {

        }

        public NumberOfTeachersByCourseIdDTO(NumberOfTeachersByCourseIdDTO dto)
        {
            CourseId = dto.CourseId;
            CourseName = dto.CourseName;
            CityId = dto.CityId;
            CityName = dto.CityName;
            Amount = dto.Amount;
            TeachersList = dto.TeachersList;
        }
    }
}

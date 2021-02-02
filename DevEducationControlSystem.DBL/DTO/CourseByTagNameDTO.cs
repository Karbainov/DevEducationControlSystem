using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class CourseByTagNameDTO
    {
        public string TagName { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public CourseByTagNameDTO()
        {

        }

        public CourseByTagNameDTO(CourseByTagNameDTO dto)
        {
            TagName = dto.TagName;
            CourseId = dto.CourseId;
            CourseName = dto.CourseName;
        }
    }
}

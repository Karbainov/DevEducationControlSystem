using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class CourseByTagIdDTO
    {
        public string TagName { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public CourseByTagIdDTO()
        {

        }

        public CourseByTagIdDTO(CourseByTagIdDTO dto)
        {
            TagName = dto.TagName;
            CourseId = dto.CourseId;
            CourseName = dto.CourseName;
        }
    }
}

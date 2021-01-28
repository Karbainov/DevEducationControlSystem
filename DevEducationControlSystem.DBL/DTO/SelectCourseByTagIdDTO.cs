using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class SelectCourseByTagIdDTO
    {
        public string TagName { get; set; }
        public string CourseName { get; set; }

        public SelectCourseByTagIdDTO()
        {

        }

        public SelectCourseByTagIdDTO(SelectCourseByTagIdDTO dto)
        {
            TagName = dto.TagName;
            CourseName = dto.CourseName;
        }
    }
}

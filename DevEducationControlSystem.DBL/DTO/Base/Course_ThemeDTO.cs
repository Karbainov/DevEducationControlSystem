using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class Course_ThemeDTO
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int ThemeId { get; set; }
        public Course_ThemeDTO()
        {

        }
        public Course_ThemeDTO(Course_ThemeDTO dto)
        {
            this.Id = dto.Id;
            this.CourseId = dto.CourseId;
            this.ThemeId = dto.ThemeId;
        }
    }
}

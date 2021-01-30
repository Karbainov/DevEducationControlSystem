using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class Course_ThemelDTO
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int MaterialId { get; set; }
        public Course_ThemelDTO()
        {

        }
        public Course_ThemelDTO(Course_ThemelDTO dto)
        {
            this.Id = dto.Id;
            this.CourseId = dto.CourseId;
            this.MaterialId = dto.MaterialId;
        }
    }
}
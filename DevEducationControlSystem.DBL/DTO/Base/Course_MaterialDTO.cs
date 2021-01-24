using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class Course_MaterialDTO
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int MaterialId { get; set; }
        public Course_MaterialDTO()
        {

        }
        public Course_MaterialDTO(int id, int courseId, int materialId)
        {
            Id = id;
            CourseId = courseId;
            MaterialId = materialId;
        }
    }
}

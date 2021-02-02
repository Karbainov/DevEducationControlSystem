using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class CourseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DurationInWeeks { get; set; }
        public bool IsDeleted { get; set; }
        public CourseDTO()
        {

        }
        public CourseDTO(int id, string name, string description, int durationInWeeks, bool isDeleted)
        {
            Id = id;
            Name = name;
            Description = description;
            DurationInWeeks = durationInWeeks;
            IsDeleted = isDeleted;
        }
    }
}

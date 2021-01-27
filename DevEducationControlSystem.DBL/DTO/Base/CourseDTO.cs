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
        public int DurationWeeks { get; set; }
        public bool IsDeleted { get; set; }
        public CourseDTO()
        {

        }
        public CourseDTO(int id, string name, string description, int durationWeeks, bool isDeleted)
        {
            Id = id;
            Name = name;
            Description = description;
            DurationWeeks = durationWeeks;
            IsDeleted = isDeleted;
        }
    }
}

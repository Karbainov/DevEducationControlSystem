using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class CourseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DurationInWeeks { get; set; }
        public bool IsDeleted { get; set; }

        public CourseModel()
        {

        }

        public CourseModel(CourseDTO dto)
        {
            Id = dto.Id;
            Name = dto.Name;
            Description = dto.Description;
            DurationInWeeks = dto.DurationInWeeks;
            IsDeleted = dto.IsDeleted;
        }
    }
}
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
    public CourseDTO(int Id, string Name, string Description, int DurationInWeeks, bool IsDeleted)
    {
      this.Id = Id;
      this.Name = Name;
      this.Description = Description;
      this.DurationInWeeks = DurationInWeeks;
      this.IsDeleted = IsDeleted;
      
    }
  }
}

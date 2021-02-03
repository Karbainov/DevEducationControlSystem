using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
  public class Homework_CourseDTO
  {
    public int Id { get; set; }
    public int HomeworkId { get; set; }
    public int CourseId { get; set; }

    public Homework_CourseDTO()
    {

    }
    public Homework_CourseDTO(int Id, int HomeworkId, int CourseId)
    {
      this.Id = Id;
      this.HomeworkId = HomeworkId;
      this.CourseId = CourseId;
    }
  }
}

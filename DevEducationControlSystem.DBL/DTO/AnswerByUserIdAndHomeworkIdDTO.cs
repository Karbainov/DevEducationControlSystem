using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
  public class AnswerByUserIdAndHomeworkIdDTO
  {
    public int AnswerId { get; set; }
    public string Message { get; set; }
    public DateTime Date { get; set; }
    public string Name { get; set; }
  }
}

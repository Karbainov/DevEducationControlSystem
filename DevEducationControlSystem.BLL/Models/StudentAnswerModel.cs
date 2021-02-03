using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
  public class StudentAnswerModel
  {
    public int AnswerId { get; set; }
    public string AnswerMessage { get; set; }
    public DateTime AnswerDate { get; set; }
    public string AnswerName { get; set; }
  }
}

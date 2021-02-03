using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
  public class СommentByAnswerIdDTO
  {
    public int id { get; set; }
    public string FullName { get; set; }
    public string Message { get; set; }
    public DateTime Date { get; set; }
  }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
  public class StudentAnswerModel
  {
    public int Id { get; set; }
    public int UserId { get; set; }
    public int ResourceId { get; set; }
    public string Images { get; set; }
    public string Links { get; set; }
    public int HomeworkId { get; set; }
    public DateTime Date { get; set; }
    public string Message { get; set; }
    public int StatusId { get; set; }

    public string Name { get; set; }

    public List<TeacherCommentModel> Comments { get; set; }
  }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
  public class StudentAnswerStoryAndCommentModel
  {
    public int HomeworkID { get; set; }
    public string HomeworkName { get; set; }
    public string Description { get; set; }


    public StudentAnswerModel StudentAnswers { get; set; }

    public List<TeacherCommentModel> Comments { get; set; }

  }
}

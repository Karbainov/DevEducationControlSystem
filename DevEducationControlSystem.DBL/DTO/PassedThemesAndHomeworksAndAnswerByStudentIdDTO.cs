using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
  public class PassedThemesAndHomeworksAndAnswerByStudentIdDTO
  {
    public int HomeworkId { get; set; }
    public string HomeworkName { get; set; }
    public DateTime LessonDate { get; set; }
    public int ThemeId { get; set; }
    public string ThemeName { get; set; }

    public int AnswerID { get; set; }

    public DateTime AnswerDate { get; set; }

    public string AnswerStatus { get; set; }

  }
}

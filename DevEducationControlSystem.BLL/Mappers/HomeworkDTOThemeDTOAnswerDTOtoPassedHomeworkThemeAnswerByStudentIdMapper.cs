using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.DTO;

namespace DevEducationControlSystem.BLL.Mappers
{
  public class HomeworkDTOThemeDTOAnswerDTOtoPassedHomeworkThemeAnswerByStudentIdMapper
  {
    public List<PassedThemesAndHomeworksAndAnswerModel> Map(List<PassedThemesAndHomeworksAndAnswerByStudentIdDTO> ThemesHomeworksAnswer)
    {
      var resultList = new List<PassedThemesAndHomeworksAndAnswerModel>();
      foreach (var dtoModel in ThemesHomeworksAnswer)
      {
        var model = new PassedThemesAndHomeworksAndAnswerModel()
        {
          HomeworkId = dtoModel.HomeworkId,
          HomeworkName = dtoModel.HomeworkName,
          LessonDate = dtoModel.LessonDate,
          ThemeId = dtoModel.ThemeId,
          ThemeName = dtoModel.ThemeName,
          AnswerID = dtoModel.AnswerID,
          AnswerDate = dtoModel.AnswerDate,
          AnswerStatus = dtoModel.AnswerStatus
        };
        resultList.Add(model);
      }
      return resultList;
    }
  }
}

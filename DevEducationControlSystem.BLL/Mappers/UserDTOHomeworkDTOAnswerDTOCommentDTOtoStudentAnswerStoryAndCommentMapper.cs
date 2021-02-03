using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.DTO.Base;

namespace DevEducationControlSystem.BLL.Mappers
{
  public class UserDTOHomeworkDTOAnswerDTOCommentDTOtoStudentAnswerStoryAndCommentMapper
  {
    public List<StudentAnswerStoryAndCommentModel> Map(List<СommentByAnswerIdDTO> commentByAnswer,
      HomeworkDTO homeworkInfo, AnswerByUserIdAndHomeworkIdDTO answerInfo)
    {
      var resultList = new List<StudentAnswerStoryAndCommentModel>();
      {
        var studentAnswerStoryAndCommentModel = new StudentAnswerStoryAndCommentModel()
        {
          HomeworkID = homeworkInfo.Id,
          HomeworkName = homeworkInfo.Name,
          Description = homeworkInfo.Description,
          StudentAnswers = new StudentAnswerModel()
          {
            AnswerId = answerInfo.AnswerId,
            AnswerMessage = answerInfo.Message,
            AnswerDate = answerInfo.Date,
            AnswerName = answerInfo.Name
          },
          Comments = new List<TeacherCommentModel>()
        };

        foreach (var comment in commentByAnswer)
        {
          TeacherCommentModel r = new TeacherCommentModel()
          {
            CommentId = comment.id,
            FullName = comment.FullName,
            CommentMessage = comment.Message,
            MessageDate = comment.Date
          };
          if (r != null)
          {
            studentAnswerStoryAndCommentModel.Comments.Add(r);
          }
        }
        resultList.Add(studentAnswerStoryAndCommentModel);
        
      }
      return resultList;
    }
  }
}



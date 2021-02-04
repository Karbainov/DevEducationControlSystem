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
    public StudentAnswerModel Map(List<СommentByAnswerIdDTO> commentByAnswer,
     AnswerDTO answerInfo)
    {
      
          var studentAnswer = new StudentAnswerModel()
          {
            Id = answerInfo.Id,
            UserId = answerInfo.UserId,
             ResourceId = answerInfo.ResourceId,
            HomeworkId = answerInfo.HomeworkId,
            Date = answerInfo.Date,
            Message = answerInfo.Message,
            StatusId = answerInfo.StatusId,

            Comments = new List<TeacherCommentModel>()
          };

        foreach (var comment in commentByAnswer)
        {
          studentAnswer.Comments.Add( new TeacherCommentModel()
          {
            CommentId = comment.id,
            FullName = comment.FullName,
            CommentMessage = comment.Message,
            MessageDate = comment.Date
          });    
        } 
      return studentAnswer;
    }
  }
}

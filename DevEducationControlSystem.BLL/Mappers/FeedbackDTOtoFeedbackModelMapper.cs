using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.DTO.Base;

namespace DevEducationControlSystem.BLL.Mappers
{
    class FeedbackDTOtoFeedbackModelMapper
    {
        public List<FeedbackModel> Map(List<FeedbackDTO> dto)
        {
            var feedback = new List<FeedbackModel>();

            foreach(var d in dto)
            {
                feedback.Add(new FeedbackModel()
                {
                    Id = d.Id,
                    UserId = d.UserId,
                    LessonId = d.LessonId,
                    Rate = d.Rate,
                    Message = d.Message
                });
            }

           
            return feedback;
        }
    }
}

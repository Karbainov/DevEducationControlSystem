using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.DTO.Base;

namespace DevEducationControlSystem.BLL.Mappers
{
    class FeedbackDTOtoFeedbackModelMapper
    {
        public FeedbackModel Map(FeedbackDTO dto)
        {
            var feedback = new FeedbackModel()
            {
                Id = dto.Id,
                UserId = dto.UserId,
                LessonId = dto.LessonId,
                Rate = dto.Rate,
                Message = dto.Message
            };
            return feedback;
        }
    }
}

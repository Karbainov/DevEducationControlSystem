using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class FeedbackDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int LessonId { get; set; }
        public int Rate { get; set; }
        public string Message { get; set; }

        public FeedbackDTO()
        {

        }

        public FeedbackDTO (int id, int userId, int lessonId, int rate, string message)
        {
            Id = id;
            UserId = userId;
            LessonId = lessonId;
            Rate = rate;
            Message = message;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.WholeCourseFeedback
{
    public class WholeCourseFeedbackDTO
    {
        public int UserId;
        public string FirstName;
        public string LastName;
        public int GroupId;
        public int FeedbackId;
        public int LessonId;
        public int Rate;
        public string Message;
        public List<ThemeFromCourseFeedbackDTO> ThemeFromCourseFeedbackDTOs;

        public WholeCourseFeedbackDTO()
        {

        }
        public WholeCourseFeedbackDTO(int userId, string firstName, string lastName, int groupId, int feedbackId, int lessonId, int rate, string message, List<ThemeFromCourseFeedbackDTO> themeFromCourseFeedbackDTOs)
        {
            UserId = userId;
            FirstName = firstName;
            LastName= lastName;
            GroupId = groupId;
            FeedbackId = feedbackId;
            LessonId = lessonId;
            Rate = rate;
            Message = message;
            ThemeFromCourseFeedbackDTOs = themeFromCourseFeedbackDTOs;
        }
    }
}

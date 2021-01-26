using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class LessonAndFeedbackDTO
    {
		public int UserId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int LessonId { get; set; }
		public string LessonName { get; set; }
		public bool IsPresent { get; set; }
		public string Feedback { get; set; }
		public int Rate { get; set; }
		public DateTime LessonDate { get; set; }

		public LessonAndFeedbackDTO()
        {

        }
	}
}

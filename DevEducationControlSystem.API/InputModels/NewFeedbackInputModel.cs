using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEducationControlSystem.API.InputModels
{
    public class NewFeedbackInputModel
    {
        public int UserId { get; set; }
        public int LessonId { get; set; }
        public int Rate { get; set; }
        public string Message { get; set; }
    }
}

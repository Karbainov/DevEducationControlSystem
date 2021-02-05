using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEducationControlSystem.API.InputModels
{
    public class FeedbackInputModel
    {
        public int? Id { get; set; }
        public int UserId { get; set; }
        public int LessonId { get; set; }
        public int Rate { get; set; }
        public string Message { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class PassedLessonByStudentIdDTO
    {
        public int LessonId { get; set; }
        public string LessonName { get; set; }
        public DateTime LessonDate { get; set; }
        public string Comments { get; set; }
        public List<string> ThemeName {get; set; }
    }
}

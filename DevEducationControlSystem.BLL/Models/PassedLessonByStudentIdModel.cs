using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.DBL.DTO;

namespace DevEducationControlSystem.BLL.Models
{
    public class PassedLessonByStudentIdModel
    {
        public int LessonId { get; set; }
        public string LessonName { get; set; }
        public DateTime LessonDate { get; set; }
        public string Comments { get; set; }
        public List<string> ThemeName {get; set;}

        public PassedLessonByStudentIdModel(PassedLessonByStudentIdDTO dto)
        {
            LessonId = dto.LessonId;
            LessonName = dto.LessonName;
            LessonDate = dto.LessonDate;
            Comments = dto.Comments;
            ThemeName = new List<string>(dto.ThemeName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.DBL.DTO;

namespace DevEducationControlSystem.BLL.Models
{
    public class PassedLessonByStudentIdModel
    {
        public string LessonName;
        public DateTime LessonDate;
        public string Comments;

        public PassedLessonByStudentIdModel(PassedLessonByStudentIdDTO dto)
        {
            LessonName = dto.LessonName;
            LessonDate = dto.LessonDate;
            Comments = dto.Comments;
        }
    }
}

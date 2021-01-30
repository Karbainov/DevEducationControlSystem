using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.DBL.DTO.WholeCourseFeedback;

namespace DevEducationControlSystem.DBL.DTO
{
    public class PassedLessonDTO
    {
        public int LessonId;
        public DateTime LessonDate;
        public List<ThemeFromCourseDTO> themeFromCourseDTOs;
    }
}

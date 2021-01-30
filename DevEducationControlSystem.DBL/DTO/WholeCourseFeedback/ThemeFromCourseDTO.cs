using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.WholeCourseFeedback
{
    public class ThemeFromCourseDTO
    {
        public int ThemeId;
        public string ThemeName;

        public ThemeFromCourseDTO(int themeId, string themeName)
        {
            ThemeId = themeId;
            ThemeName = themeName;
        }
    }
}

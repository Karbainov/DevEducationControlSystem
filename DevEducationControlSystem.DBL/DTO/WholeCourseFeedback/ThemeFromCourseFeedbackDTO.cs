using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.WholeCourseFeedback
{
    public class ThemeFromCourseFeedbackDTO
    {
        public int ThemeId;
        public string ThemeName;

        public ThemeFromCourseFeedbackDTO(int themeId, string themeName)
        {
            ThemeId = themeId;
            ThemeName = themeName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    class SelectAllThemeOnCourseDTO
    {
        public int ThemeId { get; set; }
        public string Theme { get; set; }
        public SelectAllThemeOnCourseDTO()
        {

        }
        public SelectAllThemeOnCourseDTO(SelectAllThemeOnCourseDTO dto)
        {
            ThemeId = dto.ThemeId;
            Theme = dto.Theme;
        }
    }
}

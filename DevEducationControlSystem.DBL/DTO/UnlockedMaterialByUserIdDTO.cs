using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class UnlockedMaterialByUserIdDTO
    {
        public int MaterialId { get; set; }
        public int LessonId { get; set; }
        public int ResourceId { get; set; }
        public string MaterialName { get; set; }
        public string Message { get; set; }
        public string Links { get; set; }
        public string Images { get; set; }
        public string MaterialThemeId { get; set; }
        public string MaterialThemeName { get; set; }

    }
}

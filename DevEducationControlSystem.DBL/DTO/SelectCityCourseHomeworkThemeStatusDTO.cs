using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
   public class SelectCityCourseHomeworkThemeStatusDTO
    {
        public string Cityname { get; set; }
        public string CourseName { get; set; }
        public string GroupStatus { get; set; }
        public string Themename { get; set; }

        public List<SelectStudentsHomeworkStatusDTO> groupList { get; set; }

    }
}

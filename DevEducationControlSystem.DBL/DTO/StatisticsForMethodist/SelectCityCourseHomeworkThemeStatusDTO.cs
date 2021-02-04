using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.StatisticsForMethodist
{
   public class SelectCityCourseHomeworkThemeStatusDTO
    {
        
        public string CityName { get; set; }
        

        public List<HomeworkStatusbyThemeInCourseDTO> HomeworkStatusbyThemeInCourse { get; set; }
   

    }
}

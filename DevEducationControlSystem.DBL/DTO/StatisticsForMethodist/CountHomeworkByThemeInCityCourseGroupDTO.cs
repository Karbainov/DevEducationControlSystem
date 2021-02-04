using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.StatisticsForMethodist
{
   public class CountHomeworkByThemeInCityCourseGroupDTO
    {
        
        public string CityName { get; set; }
        

        public List<GroupInCourseDTO> GroupInCourse { get; set; }
   

    }
}

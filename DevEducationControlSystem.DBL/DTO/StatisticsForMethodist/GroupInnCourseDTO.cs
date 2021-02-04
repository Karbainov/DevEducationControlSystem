using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.StatisticsForMethodist
{
   public class GroupInCourseDTO

    {
        public string CourseName { get; set; }
       
        public List<ThemeInGroupDTO> ThemeInGroup { get; set; }
        

    }
}

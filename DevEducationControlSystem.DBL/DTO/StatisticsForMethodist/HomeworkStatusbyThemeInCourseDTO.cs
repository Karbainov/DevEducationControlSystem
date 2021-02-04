using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.StatisticsForMethodist
{
   public class HomeworkStatusbyThemeInCourseDTO
    {
        public string CourseName { get; set; }
       
        public List<SelectStudentsHomeworkStatusDTO> SelectStudentsHomeworkStatus { get; set; }
        

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.StatisticsForMethodist
{
   public  class HomeworkStatusbyThemeDTO
    {
        public string GroupName { get; set; }
        public string GroupStatus { get; set; }

        public List<SelectStudentsHomeworkStatusDTO> SelectStudentsHomeworkStatus { get; set; }
    }
}

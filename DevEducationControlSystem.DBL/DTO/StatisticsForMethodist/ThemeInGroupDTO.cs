using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.StatisticsForMethodist
{
   public  class ThemeInGroupDTO
    {
        public string GroupName { get; set; }
        public string GroupStatus { get; set; }

        public List<CountOfHomeworkByThemeDTO> SelectStudentsHomeworkStatus { get; set; }
    }
}

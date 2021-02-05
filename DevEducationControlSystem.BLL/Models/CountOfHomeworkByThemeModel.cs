using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class CountOfHomeworkByThemeModel
    {
        public string HomeworkName { get; set; }
        public string ThemeName { get; set; }
        public int DoneHomework { get; set; }
        public int NotDoneHomework { get; set; }
        public int HomeworkDoneOnTime { get; set; }
        public int LateDoneHomework { get; set; }
    }
}

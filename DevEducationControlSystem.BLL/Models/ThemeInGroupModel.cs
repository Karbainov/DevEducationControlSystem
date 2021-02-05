using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
   public class ThemeInGroupModel
    {
        public string GroupName { get; set; }
        public string GroupStatus { get; set; }

        public List<CountOfHomeworkByThemeModel> CountOfHomeworkByTheme { get; set; }
    }
}

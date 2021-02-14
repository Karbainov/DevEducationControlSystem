using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class ThemeInfoModel
    {
        public int Id;
        public string Name { get; set; }
        public List<MaterialInfoModel> Materials {get; set;}
    }
}

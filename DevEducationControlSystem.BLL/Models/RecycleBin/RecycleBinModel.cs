using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models.RecycledBin
{
    public class RecycleBinModel
    {
        public List<HomeworkModel> Homeworks { get; set; }

        public List<MaterialModel> Materials { get; set; }

        public List<CourseModel> Courses { get; set; }
    }
}

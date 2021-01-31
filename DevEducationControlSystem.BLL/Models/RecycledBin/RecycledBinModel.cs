using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models.RecycledBin
{
    class RecycledBinModel
    {
        public List<HomeworkModel> Homeworks { get; set; }

        public List<MaterialModel> Materials { get; set; }

        public List<CourseModel> Courses { get; set; }
    }
}

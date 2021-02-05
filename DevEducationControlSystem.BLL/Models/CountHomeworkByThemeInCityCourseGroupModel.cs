using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class CountHomeworkByThemeInCityCourseGroupModel
    {
        public string CityName { get; set; }


        public List<GroupInCourseModel> GroupInCourse { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class GroupInCourseModel
    {
        public string CourseName { get; set; }

        public List<ThemeInGroupModel> ThemeInGroup { get; set; }
    }
}

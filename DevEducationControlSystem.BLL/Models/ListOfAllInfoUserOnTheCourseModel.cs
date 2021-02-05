using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class ListOfAllInfoUserOnTheCourseModel
    {      
        public List<InfoStudentsOnTheCourseModel> Course { get; set; }
        public List<AllInfoUserOnTheCourseModel> Info { get; set; }
    }
}

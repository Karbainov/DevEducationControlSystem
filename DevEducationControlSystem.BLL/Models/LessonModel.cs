using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class LessonModel
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public DateTime LessonDate { get; set; }
        public string Comments { get; set; }
    }
}

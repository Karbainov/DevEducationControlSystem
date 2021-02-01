using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEducationControlSystem.API.InputModels
{
    public class LessonInputModel
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public DateTime LessonDate { get; set; }
        public string Comments { get; set; }
    }
}

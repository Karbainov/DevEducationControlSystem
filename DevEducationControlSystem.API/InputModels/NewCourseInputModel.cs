using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEducationControlSystem.API.InputModels
{
    public class NewCourseInputModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int DurationInWeeks { get; set; }
    }
}

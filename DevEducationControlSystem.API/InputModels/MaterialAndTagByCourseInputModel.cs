using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEducationControlSystem.API.InputModels
{
    public class MaterialAndTagByCourseInputModel
    {
        public string Name { get; set; }
        public string ResourceLinks { get; set; }
        public string ResourceImage { get; set; }
        public string Tag { get; set; }
    }
}

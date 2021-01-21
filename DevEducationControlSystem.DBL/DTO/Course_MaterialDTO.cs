using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class Course_MaterialDTO
    {
        public string Tag { get; set; }
        public string Links { get; set; }
        public string Images { get; set; }
        public int MaterialId { get; set; }
        public Course_MaterialDTO(string tag, string links, string images, int materialId)
        {
            Tag = tag;
            Links = links;
            Images = images;
            MaterialId = materialId;
        }
    }
}

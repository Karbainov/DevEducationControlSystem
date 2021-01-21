using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class TagsFromAllMaterialsDTO
    {
        public string Tag { get; set; }
        public string Links { get; set; }
        public string Images { get; set; }
        public string Material_name { get; set; }
        public int MaterialId { get; set; }
        public TagsFromAllMaterialsDTO(string tag, string links, string images, string material_name, int materialId)
        {
            Tag = tag;
            Links = links;
            Images = images;
            Material_name = material_name;
            MaterialId = materialId;
        }
    }
}

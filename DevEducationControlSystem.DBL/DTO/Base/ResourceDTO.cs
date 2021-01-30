using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class ResourceDTO
    {
        public int ResourceId { get; set; }
        public string ResourceLinks { get; set; }
        public string ResourceImage { get; set; }

        public ResourceDTO()
        {

        }

        public ResourceDTO(ResourceDTO dto)
        {
            ResourceId = dto.ResourceId;
            ResourceLinks = dto.ResourceLinks;
            ResourceImage = dto.ResourceImage;
        }
    }
}

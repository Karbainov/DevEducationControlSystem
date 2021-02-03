using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class Material_TagDTO
    {

        public int Id { get; set; }
        public int MaterialId { get; set; }
        public int TagId { get; set; }

        public Material_TagDTO()
        {

        }

        public Material_TagDTO(int id, int materialId, int tagId)
        {
            Id = id;
            MaterialId = materialId;
            TagId = tagId;
        }
    }
}

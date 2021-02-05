using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class MaterialDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ResourceId { get; set; }
        public string Name { get; set; }
        public string? Message { get; set; }
        public bool IsDeleted { get; set; }

        public MaterialDTO()
        {

        }

        public MaterialDTO(
            int id,
            int userid,
            int resourceid,
            string name,
            string message,
            bool isdeleted)
        {
            Id = id;
            UserId = userid;
            ResourceId = resourceid;
            Name = name;
            Message = message;
            IsDeleted = isdeleted;
        }
    }
}

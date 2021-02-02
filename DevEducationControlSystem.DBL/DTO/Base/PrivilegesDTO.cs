using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class PrivilegesDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public PrivilegesDTO()
        {

        }

        public PrivilegesDTO(PrivilegesDTO dto)
        {
            this.Id = dto.Id;
            this.Name = dto.Name;
        }
    }
}

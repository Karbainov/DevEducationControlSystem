using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class PrivilegesDTO
    {
        public int id { get; set; }
        public string name { get; set; }

        public PrivilegesDTO()
        {

        }

        public PrivilegesDTO(PrivilegesDTO dto)
        {
            this.id = dto.id;
            this.name = dto.name;
        }
    }
}

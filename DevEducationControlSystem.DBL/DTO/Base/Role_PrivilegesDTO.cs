using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    class Role_PrivilegesDTO
    {
        public int Id { get; set; }

        public int RoleId { get; set; }

        public int PrivilegesId { get; set; }

        public Role_PrivilegesDTO()
        {

        }

        public Role_PrivilegesDTO(Role_PrivilegesDTO dto)
        {
            this.Id = dto.Id;
            this.RoleId = dto.RoleId;
            this.PrivilegesId = dto.PrivilegesId;
        }
        
    }
}

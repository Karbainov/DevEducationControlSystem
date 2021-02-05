using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class RoleForGroupInfoDTO
    {
        public int? RoleId { get; set; }
        public string Role { get; set; }

        public RoleForGroupInfoDTO()
        { }

        public RoleForGroupInfoDTO(RoleForGroupInfoDTO dto)
        {
            RoleId = dto.RoleId;
            Role = dto.Role;
        }
    }
}

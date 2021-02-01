using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class LoginPassRoleDTO
    {
        public int UserId {get; set;}
        public string UserLog { get; set;}
        public string UserPas {get; set;}
        public List<RoleDTO> Role {get; set;}
    }
}

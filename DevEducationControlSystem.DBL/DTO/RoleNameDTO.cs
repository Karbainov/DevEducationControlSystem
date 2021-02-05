using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class RoleNameDTO
    {
        string RoleName { get; set; }
        public RoleNameDTO ()
        {

        }
        public RoleNameDTO(string rolename)
        {
            RoleName = rolename;
        }
    }
}

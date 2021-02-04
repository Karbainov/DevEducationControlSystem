using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class LoginPassRoleModel
    {
        public int UserId { get; set; }
        public string UserLog { get; set; }
        public string UserPas { get; set; }
        public List<RoleModel> Roles { get; set; }


/*        public LoginPassRoleModel(LoginPassRoleDTO dto)
        {
            UserId = dto.UserId;
            UserLog = dto.UserLog;
            UserPas = dto.UserPas;
            
        }*/
    }
}

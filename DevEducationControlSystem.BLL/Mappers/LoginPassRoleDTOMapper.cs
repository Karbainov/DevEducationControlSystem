using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Mappers
{
    public class LoginPassRoleDTOMapper
    {
        public LoginPassRoleModel Map(LoginPassRoleDTO dto)
        {

            var logPasRolMod = new LoginPassRoleModel()
            {
                UserId = dto.UserId,
                UserLog = dto.UserLog,
                UserPas = dto.UserPas,
                Roles = new List<RoleModel>()
            };
            foreach (var r in dto.Roles)
            {
                if (r != null)
                {
                    logPasRolMod.Roles.Add(new RoleModel(r));
                }
            }


            return logPasRolMod;

        }
    }
}

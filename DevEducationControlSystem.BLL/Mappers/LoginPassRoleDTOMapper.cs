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
        public List<LoginPassRoleModel> Map(List<LoginPassRoleDTO> dto)
        {
            var loginPassRoleModels = new List<LoginPassRoleModel>();

            foreach (var log in dto)
            {
                var logPasRolMod = new LoginPassRoleModel()
                {
                    UserId = log.UserId,
                    UserLog = log.UserLog,
                    UserPas = log.UserPas,
                    Roles = new List<RoleModel>()
                };
                foreach(var r in log.Roles)
                {
                    if (r != null)
                    {
                        logPasRolMod.Roles.Add(new RoleModel(r));
                    }
                }
                
                loginPassRoleModels.Add(logPasRolMod);
            };

            return loginPassRoleModels;

        }
    }
}

using DevEducationControlSystem.BLL.Mappers;
using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.CRUD;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL
{
    public class AuthorizationLogicManager
    {
        public List<LoginPassRoleModel> GetLoginPassworlRole(string login)
        {
            var userManager = new UserManager();
            var mapper = new LoginPassRoleDTOMapper();

            return mapper.Map(userManager.GetLoginPassRole(login));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevEducationControlSystem.DBL.CRUD;
using DevEducationControlSystem.DBL.DTO;

namespace DevEducationControlSystem.API
{
    static class IdRevieser
    {
        public static bool RevieseId(string login, int userId)
        {
            return new UserManager().RevieseId(login, userId);
        }
    }
}

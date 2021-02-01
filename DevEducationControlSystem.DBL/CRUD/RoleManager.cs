using Dapper;
using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class RoleManager
    {
        public RoleDTO SelectById(int id)
        {
            var RoleDTO = SqlServerConnection.GetConnection().Query<RoleDTO>("[Role_SelectById]", id, commandType: CommandType.StoredProcedure).Single<RoleDTO>();
            return RoleDTO;
        }
    }
}

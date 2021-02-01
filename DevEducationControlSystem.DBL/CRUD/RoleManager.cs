using Dapper;
using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class RoleManager
    {
        public List<NumberOfPeoplePerRoleDTO> GetNumberOfPeoplePerRole()
        {
            string expr = "[GetNumberOfPeoplePerRole]";
            using (var connection = SqlServerConnection.GetConnection())
            {
                return connection.Query<NumberOfPeoplePerRoleDTO>(
                    expr,
                    commandType: CommandType.StoredProcedure
                    ).AsList<NumberOfPeoplePerRoleDTO>();
            }
        }
    }
}

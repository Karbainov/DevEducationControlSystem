using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DevEducationControlSystem.DBL.DTO.Base;
using System.Data;
using Dapper;
using System.Linq;


namespace DevEducationControlSystem.DBL.CRUD
{
    public class PrivilegesManager
    {
        public List<PrivilegesDTO> Select()
        {
            using (var connection = SqlServerConnection.GetConnection())
            {
                var ListPrivilegesDTOs = connection.Query<PrivilegesDTO>("[Privileges_Select]", commandType: CommandType.StoredProcedure).AsList<PrivilegesDTO>();
                return ListPrivilegesDTOs;
            }
        }

        public PrivilegesDTO SelectById(int id)
        {
            using (var connection = SqlServerConnection.GetConnection())
            {
                var PrivilegesDTO = connection.QuerySingle<PrivilegesDTO>("[Privileges_SelectById]", id, commandType: CommandType.StoredProcedure);
                return PrivilegesDTO;
            }
        }

        public void Update(int id, int name)
        {
            using (var connection = SqlServerConnection.GetConnection())
            {
                var value = new { id, name };
                connection.Query("[Privileges_Update]", value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int id)
        {
            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query("[Role_Privileges_Delete]", id, commandType: CommandType.StoredProcedure);
            }
        }

        public void Add(string name)
        {
            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query("[Role_Privileges_Add]", name, commandType: CommandType.StoredProcedure);
            }
        }

    }
}

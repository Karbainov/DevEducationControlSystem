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
    public class Role_PrivilegesManager
    {
        public List<Role_PrivilegesDTO> Select()
        {
            using (var connection = SqlServerConnection.GetConnection())
            {
                var ListRole_PrivilegesDTOs = connection.Query<Role_PrivilegesDTO>("[Role_Privileges_Select]", commandType: CommandType.StoredProcedure).AsList<Role_PrivilegesDTO>();
                return ListRole_PrivilegesDTOs;
            }
        }

        public Role_PrivilegesDTO SelectById(int id)
        {
            using (var connection = SqlServerConnection.GetConnection())
            {
                var Role_PrivilegesDTO = connection.Query<Role_PrivilegesDTO>("[Role_Privileges_SelectById]", id, commandType: CommandType.StoredProcedure).Single<Role_PrivilegesDTO>();
                return Role_PrivilegesDTO;
            }
        }

        public void Update(int id, int RoleId, int PrivilegesId)
        {
            using (var connection = SqlServerConnection.GetConnection())
            {
                var value = new { id, RoleId, PrivilegesId };
                connection.Query("[Role_Privileges_Update]", value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int id)
        {
            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query("[Role_Privileges_Delete]", id, commandType: CommandType.StoredProcedure);
            }
        }

        public void Add(int RoleId, int PrivilegesId)
        {
            using (var connection = SqlServerConnection.GetConnection())
            {
                var value = new { RoleId, PrivilegesId };
                connection.Query("[Role_Privileges_Add]", value, commandType: CommandType.StoredProcedure);
            }
        }
    }
    
}

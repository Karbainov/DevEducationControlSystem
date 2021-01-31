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
            var ListRole_PrivilegesDTOs = SqlServerConnection.GetConnection().Query<Role_PrivilegesDTO>("[Role_Privileges_Select]", commandType: CommandType.StoredProcedure).AsList<Role_PrivilegesDTO>();
            return ListRole_PrivilegesDTOs;
        }

        public Role_PrivilegesDTO SelectById(int id)
        {
            var Role_PrivilegesDTO = SqlServerConnection.GetConnection().Query<Role_PrivilegesDTO>("[Role_Privileges_SelectById]", id, commandType: CommandType.StoredProcedure).Single<Role_PrivilegesDTO>();
            return Role_PrivilegesDTO;
        }

        public void Update(int id, int RoleId, int PrivilegesId)
        {
            var value = new { id, RoleId, PrivilegesId };
            SqlServerConnection.GetConnection().Query("[Role_Privileges_Update]", value, commandType: CommandType.StoredProcedure);
        }

        public void Delete(int id)
        {
            SqlServerConnection.GetConnection().Query("[Role_Privileges_Delete]", id, commandType: CommandType.StoredProcedure);
        }

        public void Add(int RoleId, int PrivilegesId)
        {
            var value = new { RoleId, PrivilegesId };
            SqlServerConnection.GetConnection().Query("[Role_Privileges_Add]", value, commandType: CommandType.StoredProcedure);
        }
    }
    
}

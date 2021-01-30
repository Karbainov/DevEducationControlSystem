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
            var ListPrivilegesDTOs = SqlServerConnection.GetConnection().Query<PrivilegesDTO>("[Privileges_Select]", commandType: CommandType.StoredProcedure).AsList<PrivilegesDTO>();
            return ListPrivilegesDTOs;
        }

        public PrivilegesDTO SelectById(int id)
        {
            var PrivilegesDTO = SqlServerConnection.GetConnection().Query<PrivilegesDTO>("[Privileges_SelectById]", id, commandType: CommandType.StoredProcedure).Single<PrivilegesDTO>();
            return PrivilegesDTO;
        }

        public void Update(int id, int name)
        {
            var value = new { id, name };
            SqlServerConnection.GetConnection().Query("[RPrivileges_Update]", value, commandType: CommandType.StoredProcedure);
        }

        public void Delete(int id)
        {
            SqlServerConnection.GetConnection().Query("[Role_Privileges_Delete]", id, commandType: CommandType.StoredProcedure);
        }

        public void Add(string name)
        {
            SqlServerConnection.GetConnection().Query("[Role_Privileges_Add]", name, commandType: CommandType.StoredProcedure);
        }

    }
}

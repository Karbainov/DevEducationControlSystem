using Dapper;
using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.DTO.Base;
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

        public List<RoleDTO> Select()
        {
            using (var connection = SqlServerConnection.GetConnection())
            {
                var ListRolesDTOs = connection.Query<RoleDTO>("[Role_Select]", commandType: CommandType.StoredProcedure).AsList<RoleDTO>();
                return ListRolesDTOs;
            }
        }

        public RoleDTO SelectById(int id)
        {
            using (var connection = SqlServerConnection.GetConnection())
            {
                var RoleDTO = connection.QuerySingle<RoleDTO>("[Role_SelectById]", id, commandType: CommandType.StoredProcedure);
                return RoleDTO;
            }
        }

        public void Update(int id, int roleName)
        {
            using (var connection = SqlServerConnection.GetConnection())
            {
                var value = new { id, roleName };
                connection.Query("[Role_Update]", value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int id)
        {
            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query("[Role_Delete]", id, commandType: CommandType.StoredProcedure);
            }
        }

        public void Add(string roleName)
        {
            using (var connection = SqlServerConnection.GetConnection())
            {
                var value = new { roleName };
                connection.Query("[Role_Add]", value, commandType: CommandType.StoredProcedure);
            }
        }
    }
}

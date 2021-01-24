using Dapper;
using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;


namespace DevEducationControlSystem.DBL.CRUD
{
    public class PrivilegesManager
    {
        private SqlConnection connection;
        private string _connectionString;


        public PrivilegesManager()
        {
            _connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test; User Id = devEd; Password = qqq!11";
            connection = new SqlConnection(_connectionString);
        }

        public List<PrivilegesDTO> Select(int roleId, int PrivilegesId)
        {
            var PrivilegesDTOs = new List<PrivilegesDTO>();
            string expr = "[Privileges_Select]";
            var value = new { RoleId = roleId, PrivilegesId = PrivilegesId };

            using (var connection = new SqlConnection(_connectionString))
            {
                PrivilegesDTOs = connection.Query<PrivilegesDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList();
            }

            return PrivilegesDTOs;
        }

        public PrivilegesDTO SelectById(int id)
        {
            var PrivilegesDTO = new PrivilegesDTO();

            connection.Open();

            string sqlExpression = "EXEC Privileges_SelectById " + id;
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            using SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            PrivilegesDTO.id = (int)reader["id"];
            PrivilegesDTO.name = (string)reader["name"];

            reader.Close();
            connection.Close();

            return PrivilegesDTO;
        }


        public void Update(int id)
        {
            string expr = "[Privileges_Delete]";
            var value = new { Id = id };
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int id)
        {
            string expr = "[Privileges_Delete]";
            var value = new { id = id };
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Add(int id, int name)
        {
            string expr = "[Privileges_Add]";
            var value = new { id = id, name = name };
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

    }
}

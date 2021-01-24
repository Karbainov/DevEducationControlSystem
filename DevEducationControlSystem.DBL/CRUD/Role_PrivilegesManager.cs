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
        private SqlConnection connection;
        private string _connectionString;
        

        public Role_PrivilegesManager()
        {
            _connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test; User Id = devEd; Password = qqq!11"; 
            connection = new SqlConnection(_connectionString);
        }

        public List<Role_PrivilegesDTO> Select(int roleId, int PrivilegesId)
        {
            var Role_PrivilegesDTOs = new List<Role_PrivilegesDTO>();
            string expr = "[Role_Privileges_Select]";
            var value = new { RoleId = roleId, PrivilegesId = PrivilegesId };

            using (var connection = new SqlConnection(_connectionString))
            {
                Role_PrivilegesDTOs = connection.Query<Role_PrivilegesDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList();
            }

            return Role_PrivilegesDTOs;
        }

        public Role_PrivilegesDTO SelectById(int id)
        {
            var Role_PrivilegesDTO = new Role_PrivilegesDTO();

            connection.Open();

            string sqlExpression = "EXEC Role_Privileges_SelectById " + id;
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            using SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            Role_PrivilegesDTO.Id = (int)reader["Id"];
            Role_PrivilegesDTO.RoleId = (int)reader["CourseId"];
            Role_PrivilegesDTO.PrivilegesId = (int)reader["ThemeId"];

            reader.Close();
            connection.Close();

            return Role_PrivilegesDTO;
        }


        public void Update(int id)
        {
            string expr = "[Role_Privileges_Delete]";
            var value = new { Id = id };
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int id)
        {
            string expr = "[Role_Privileges_Delete]";
            var value = new { Id = id };
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Add(int RoleId, int PrivilegesId)
        {
            string expr = "[Role_Privileges_Add]";
            var value = new { CourseId = RoleId, MaterialId = PrivilegesId };
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

    }
    
}

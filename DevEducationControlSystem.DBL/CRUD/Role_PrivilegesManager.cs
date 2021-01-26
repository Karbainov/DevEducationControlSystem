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
        private string _connectionString;
        private SqlConnection connection;


        public SqlConnection GetConnection()
        {
            _connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test; User Id = devEd; Password = qqq!11";
            SqlConnection connection = new SqlConnection(_connectionString);
            return connection;
        }
        
        public List<Role_PrivilegesDTO> Select()
        {
            var Role_PrivilegesDTOs = new List<Role_PrivilegesDTO>();
            string expr = "[Role_Privileges_Select]";


            using (var connection = GetConnection())
            {
                Role_PrivilegesDTOs = connection.Query<Role_PrivilegesDTO>(expr, commandType: CommandType.StoredProcedure).AsList<Role_PrivilegesDTO>();
            }

            return Role_PrivilegesDTOs;
        }

        public Role_PrivilegesDTO SelectById(int id)
        {
            var Role_PrivilegesDTO = new Role_PrivilegesDTO();
            var value = new { Id = id };
            string expr = "[Role_Privileges_SelectById]";

            using (connection = GetConnection())
            {
                Role_PrivilegesDTO = connection.Query<Role_PrivilegesDTO>(expr, value, commandType: CommandType.StoredProcedure).Single<Role_PrivilegesDTO>();
            }

            return Role_PrivilegesDTO;
        }


        public void Update(int id)
        {
            string expr = "[Role_Privileges_Update]";
            var value = new { Id = id };

            using (var connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int id)
        {
            string expr = "[Role_Privileges_Delete]";
            var value = new { Id = id };

            using (var connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Add(int RoleId, int PrivilegesId)
        {
            string expr = "[Role_Privileges_Add]";
            var value = new { RoleId, PrivilegesId };

            using (var connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }
        
    }
    
}

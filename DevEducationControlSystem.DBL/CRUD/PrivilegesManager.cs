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
        private string _connectionString;
        private SqlConnection connection;

        private SqlConnection GetConnection()
        {
            _connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test; User Id = devEd; Password = qqq!11";
            connection = new SqlConnection(_connectionString);
            return connection;
        }

        public List<PrivilegesDTO> Select()
        {
            var PrivilegesDTOs = new List<PrivilegesDTO>();
            string expr = "[Privileges_Select]";
            
            using (connection = GetConnection())
            {
                PrivilegesDTOs = connection.Query<PrivilegesDTO>(expr, commandType: CommandType.StoredProcedure).AsList();
            }

            return PrivilegesDTOs;
        }

        public PrivilegesDTO SelectById(int id)
        {
            var PrivilegesDTO = new PrivilegesDTO();
            string expr = "[Privileges_SelectById]";
            var value = new { id };

            using (connection = GetConnection())
            {
                PrivilegesDTO = connection.Query<PrivilegesDTO>(expr, value, commandType: CommandType.StoredProcedure).Single<PrivilegesDTO>();
            }

            return PrivilegesDTO;
        }


        public void Update(int id)
        {
            string expr = "[Privileges_Update]";
            var value = new { id };
            using (connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int id)
        {
            string expr = "[Privileges_Delete]";
            var value = new { id };
            using (connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Add(int id, int name)
        {
            string expr = "[Privileges_Add]";
            var value = new { id, name };
            using (connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

    }
}

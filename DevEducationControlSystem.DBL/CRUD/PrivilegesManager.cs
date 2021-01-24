using Dapper;
using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace DevEducationControlSystem.DBL.CRUD
{
    public class PrivilegesManager
    {

        public SqlConnection GetConnection()
        {
            string _connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test; User Id = devEd; Password = qqq!11";
            SqlConnection connection = new SqlConnection(_connectionString);
            return connection;
        }

        public List<PrivilegesDTO> Select()
        {
            var PrivilegesDTOs = new List<PrivilegesDTO>();
            string expr = "[Privileges_Select]";
            
            using (var connection = GetConnection())
            {
                PrivilegesDTOs = connection.Query<PrivilegesDTO>(expr, commandType: CommandType.StoredProcedure).AsList();
            }

            return PrivilegesDTOs;
        }

        public PrivilegesDTO SelectById(int id)
        {
            var PrivilegesDTO = new PrivilegesDTO();
            string expr = "[Privileges_SelectById]";

            using (var connection = GetConnection())
            {
                PrivilegesDTO = connection.Query<PrivilegesDTO>(expr, commandType: CommandType.StoredProcedure).Single<PrivilegesDTO>();
            }

            return PrivilegesDTO;
        }


        public void Update(int id)
        {
            string expr = "[Privileges_Update]";
            var value = new { Id = id };
            using (var connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int id)
        {
            string expr = "[Privileges_Delete]";
            var value = new { id = id };
            using (var connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Add(int id, int name)
        {
            string expr = "[Privileges_Add]";
            var value = new { id = id, name = name };
            using (var connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

    }
}

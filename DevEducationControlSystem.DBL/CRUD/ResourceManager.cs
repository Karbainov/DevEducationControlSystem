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
    public class ResourceManager
    {
        private string _connectionString;
        private SqlConnection connection;


        public SqlConnection GetConnection()
        {
            _connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test; User Id = devEd; Password = qqq!11";
            SqlConnection connection = new SqlConnection(_connectionString);
            return connection;
        }

        public List<ResourceDTO> Select()
        {
            var Role_PrivilegesDTOs = new List<ResourceDTO>();
            string expr = "[Resource_Select]";


            using (var connection = GetConnection())
            {
                Role_PrivilegesDTOs = connection.Query<ResourceDTO>(expr, commandType: CommandType.StoredProcedure).AsList<ResourceDTO>();
            }

            return Role_PrivilegesDTOs;
        }

        public ResourceDTO SelectById(int Id)
        {
            var Resource = new ResourceDTO();
            var value = new { Id };
            string expr = "[Resource_SelectById]";

            using (connection = GetConnection())
            {
                Resource = connection.Query<ResourceDTO>(expr, value, commandType: CommandType.StoredProcedure).Single<ResourceDTO>();
            }

            return Resource;
        }


        public void Update(int Id)
        {
            string expr = "[Resource_Update]";
            var value = new { Id };

            using (var connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int Id)
        {
            string expr = "[Resource_Delete]";
            var value = new { Id };

            using (var connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Add(string ResourceLinks, string ResourceImage)
        {
            string expr = "[Resource_Add]";
            var value = new { ResourceLinks, ResourceImage };

            using (var connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

    }
}

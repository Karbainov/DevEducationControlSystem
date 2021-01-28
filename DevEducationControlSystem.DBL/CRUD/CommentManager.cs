using Dapper;
using DevEducationControlSystem.DBL.DTO.Base;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class CommentManager
    {
        private string _connectionString;
        private SqlConnection connection;


        public SqlConnection GetConnection()
        {
            _connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test; User Id = devEd; Password = qqq!11";
            SqlConnection connection = new SqlConnection(_connectionString);
            return connection;
        }

        public List<CommentDTO> Select()
        {
            var comments = new List<CommentDTO>();
            string expr = "[Comment_Select]";


            using (var connection = GetConnection())
            {
                comments = connection.Query<CommentDTO>(expr, commandType: CommandType.StoredProcedure).AsList<CommentDTO>();
            }

            return comments;
        }

        public CommentDTO SelectById(int Id)
        {
            var Resource = new CommentDTO();
            var value = new { Id };
            string expr = "[Comment_SelectById]";

            using (connection = GetConnection())
            {
                Resource = connection.Query<CommentDTO>(expr, value, commandType: CommandType.StoredProcedure).Single<CommentDTO>();
            }

            return Resource;
        }


        public void Update(int Id)
        {
            string expr = "[Comment_Update]";
            var value = new { Id };

            using (var connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int Id)
        {
            string expr = "[Comment_Delete]";
            var value = new { Id };

            using (var connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Add(string ResourceLinks, string ResourceImage)
        {
            string expr = "[Comment_Add]";
            var value = new { ResourceLinks, ResourceImage };

            using (var connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

    }
}

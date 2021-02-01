using Dapper;
using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DevEducationControlSystem.DBL.DTO.Base;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class TagManager
    {
        public SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        public List<TagDTO> Select()
        {
            List<TagDTO> tags = new List<TagDTO>();
            SqlConnection connection = GetConnection();
            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                throw new Exception("DataBase connection failed");
            }

            string sqlExpression = "Tag_Select";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int id = (int)reader["Id"];
                            string name = (string)reader["Name"];
                            tags.Add(new TagDTO(id, name));
                        }
                    }
                }
            }
            finally
            {
                connection.Close();
            }
            return tags;
        }

        public TagDTO SelectById(int id)
        {
            TagDTO tag = new TagDTO();
            SqlConnection connection = GetConnection();
            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                throw new Exception("DataBase connection failed");
            }

            string sqlExpression = "Tag_SelectById";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter idParameter = new SqlParameter("@Id", id);
            command.Parameters.Add(idParameter);
            try
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int _id = (int)reader["Id"];
                            string name = (string)reader["Name"];
                            tag = new TagDTO(_id, name);
                        }
                    }
                }
            }
            finally
            {
                connection.Close();
            }
            return tag;
        }

        public void Add(string name)
        {
            string expr = "[Tag_Add]";
            var value = new { NAme=name };

            using (var connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int id)
        {
            string expr = "[Tag_Delete]";
            var value = new { Id = id };

            using (var connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(int id, string name)
        {
            string expr = "[Tag_Update]";
            var value = new { Id = id, Name=name };

            using (var connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public List<AllTagsOnCourseDTO> SelectAllTagsOnCourse(int id)
        {
            var themesList = new List<AllTagsOnCourseDTO>();
            string expr = "[SelectAllTagsOnCourse]";
            var value = new { id };

            using (var connection = GetConnection())
            {
                themesList = connection.Query<AllTagsOnCourseDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList();
            }

            return themesList;
        }
    }
}

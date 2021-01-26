using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DevEducationControlSystem.DBL.CRUD
{
    class Theme_TagManager
    {

        public SqlConnection ConnectToDB()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
        public List<Theme_TagDTO> Select()
        {
            List<Theme_TagDTO> theme_tags = new List<Theme_TagDTO>();
            SqlConnection connection = ConnectToDB();
            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                throw new Exception("DataBase connection failed");
            }

            string sqlExpression = "Theme_Tag_Select";
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
                            int themeId = (int)reader["ThemeId"];
                            int tagId = (int)reader["TagId"];
                            theme_tags.Add(new Theme_TagDTO(id, themeId, tagId));
                        }
                    }
                }
            }
            finally
            {
                connection.Close();
            }
            return theme_tags;
        }

        public Theme_TagDTO SelectById(int id)
        {
            Theme_TagDTO theme_tag = new Theme_TagDTO();
            SqlConnection connection = ConnectToDB();
            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                throw new Exception("DataBase connection failed");
            }

            string sqlExpression = "Theme_SelectById";
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
                            int themeId = (int)reader["ThemeId"];
                            int tagId = (int)reader["TagId"];
                            theme_tag = new Theme_TagDTO(_id, themeId, tagId);
                        }
                    }
                }
            }
            finally
            {
                connection.Close();
            }
            return theme_tag;
        }
    }
}

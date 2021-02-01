using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data;
using Dapper;

namespace DevEducationControlSystem.DBL.CRUD
{
    class Material_TagManager
    {

        public SqlConnection ConnectToDB()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
        public List<Material_TagDTO> Select()
        {
            List<Material_TagDTO> material_tags = new List<Material_TagDTO>();
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

            string sqlExpression = "Material_Tag_Select";
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
                            int materialId = (int)reader["MaterialId"];
                            int tagId = (int)reader["TagId"];
                            material_tags.Add(new Material_TagDTO(id, materialId, tagId));
                        }
                    }
                }
            }
            finally
            {
                connection.Close();
            }
            return material_tags;
        }

        public Material_TagDTO SelectById(int id)
        {
            Material_TagDTO material_tag = new Material_TagDTO();
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

            string sqlExpression = "Material_Tag_SelectById";
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
                            int materialId = (int)reader["MaterialId"];
                            int tagId = (int)reader["TagId"];
                            material_tag = new Material_TagDTO(_id, materialId, tagId);
                        }
                    }
                }
            }
            finally
            {
                connection.Close();
            }
            return material_tag;
        }

        public void Add(int materialId, int tagId)
        {
            string expr = "[Material_Tag_Add]";
            var value = new { MaterialId = materialId, TagId = tagId };

            using (var connection = ConnectToDB())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int id)
        {
            string expr = "[Material_Tag_Delete]";
            var value = new { Id = id };

            using (var connection = ConnectToDB())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(int id, int materialId, int tagId)
        {
            string expr = "[Material_Tag_Update]";
            var value = new { Id = id, ThemeId = materialId, MaterialId = tagId };

            using (var connection = ConnectToDB())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }
    }
}

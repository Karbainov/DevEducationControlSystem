using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DevEducationControlSystem.DBL.DTO.Base;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class Theme_MaterialManager
    {
        public SqlConnection ConnectToDB()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
        public List<Theme_MaterialDTO> Select()
        {
            List<Theme_MaterialDTO> themesMaterial = new List<Theme_MaterialDTO>();
            SqlConnection connection = ConnectToDB();
            connection.Open();

            string sqlExpression = "Theme_Material_Select";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = (int)reader["Id"];
                    int themeId = (int)reader["themeId"];
                    int materialId = (int)reader["materialId"];

                    themesMaterial.Add(new Theme_MaterialDTO(id, themeId, materialId));
                }
            }
            reader.Close();
            connection.Close();
            return themesMaterial;
        }

        public Theme_MaterialDTO SelectById(int id)
        {
            Theme_MaterialDTO themesMaterial = new Theme_MaterialDTO();
            SqlConnection connection = ConnectToDB();
            connection.Open();

            string sqlExpression = "Theme_Material_SelectById";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter idParameter = new SqlParameter("@Id", id);
            command.Parameters.Add(idParameter);

            SqlDataReader reader = command.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id2 = (int)reader["id"];
                    int themeId = (int)reader["themeId"];
                    int materialId = (int)reader["materialId"];

                    themesMaterial = new Theme_MaterialDTO(id2, themeId, materialId);
                }
            }
            reader.Close();
            connection.Close();
            return themesMaterial;
        }
    }
}

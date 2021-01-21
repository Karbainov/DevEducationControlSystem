using System;
using DevEducationControlSystem.DBL.DTO.Base;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class MaterialManager
    {
        public SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        public List<MaterialDTO> Select()
        {
            List<MaterialDTO> materials = new List<MaterialDTO>();
            SqlConnection connection = GetConnection();
            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                throw new Exception("Failed to connect");
            }
            string sqlExpression = "Material_Select";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read()) // Read() возвращает тру или фолз, если в строке что-то есть то тру; возврат данных построчно
                {
                    int id = (int)reader["Id"];
                    int userid = (int)reader["UserId"];
                    int resourceid = (int)reader["ResouceId"];
                    string name = (string)reader["Name"];
                    string message = (string)reader["Message"];
                    bool isdeleted = (bool)reader["IsDeleted"];
                    materials.Add(new MaterialDTO(id, userid, resourceid, name, message, isdeleted));
                }
            }
            reader.Close();
            connection.Close();

            return materials;
        }

        public MaterialDTO SelectById(int Id)
        {
            MaterialDTO material = new MaterialDTO();
            SqlConnection connection = GetConnection();
            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                throw new Exception("Failed to connect");
            }

            string sqlExpression = "Material_SelectById";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter idParam = new SqlParameter("@Id", Id);
            command.Parameters.Add(idParam);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read()) // Read() возвращает тру или фолз, если в строке что-то есть то тру; возврат данных построчно
                {
                    int id = (int)reader["Id"];
                    int userid = (int)reader["UserId"];
                    int resourceid = (int)reader["ResouceId"];
                    string name = (string)reader["Name"];
                    string message = (string)reader["Message"];
                    bool isdeleted = (bool)reader["IsDeleted"];
                    material = new MaterialDTO(id, userid, resourceid, name, message, isdeleted);
                }
            }
            reader.Close();
            connection.Close();

            return material;
        }

    }
}

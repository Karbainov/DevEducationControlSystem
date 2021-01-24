using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DevEducationControlSystem.DBL.DTO.Base;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class Answer_StatusManager
    {

        private static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            var connection = new SqlConnection(connectionString);
            return connection;
        }

        public List<Answer_StatusDTO> Select()
        {
            var Answer_StatusDTOs = new List<Answer_StatusDTO>();
            var connection = GetConnection();

            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                throw new Exception("Connection failed");
            }

            string sqlExpression = "Answer_Status_Select";
            var command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    int Id = (int)reader["Id"];
                    string Name = (string)reader["Name"];
                    Answer_StatusDTOs.Add(new Answer_StatusDTO(Id, Name));
                }
            }
            reader.Close();
            connection.Close();
            return Answer_StatusDTOs;
        }

        public Answer_StatusDTO SelectById(int id)
        {
            var Answer_StatusDTO = new Answer_StatusDTO();
            var connection = GetConnection();

            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                throw new Exception("Connection failed");
            }

            string sqlExpression = "Answer_Status_SelectById";
            var command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            var idParameter = new SqlParameter("@Id", id);
            command.Parameters.Add(idParameter);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) 
            {
                reader.Read();
                int Id = (int)reader["Id"];
                string Name = (string)reader["Name"];
                Answer_StatusDTO = new Answer_StatusDTO(Id, Name);
            }
            reader.Close();
            connection.Close();
            return Answer_StatusDTO;
        }
    }
}

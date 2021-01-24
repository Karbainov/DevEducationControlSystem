using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DevEducationControlSystem.DBL.DTO.Base;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class AnswerManager
    {

        private static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            var connection = new SqlConnection(connectionString);
            return connection;
        }

        public List<AnswerDTO> Select()
        {
            var answerDTOs = new List<AnswerDTO>();
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

            string sqlExpression = "Answer_Select";
            var command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    int Id = (int)reader["Id"];
                    int UserId = (int)reader["UserId"];
                    int ResourceId = (int)reader["ResourceId"];
                    int HomeworkId = (int)reader["HomeworkId"];
                    DateTime Date = (DateTime)reader["Date"];
                    string Message = (string)reader["Message"];
                    int StatusId = (int)reader["StatusId"];

                    answerDTOs.Add(new AnswerDTO(Id, UserId, ResourceId, HomeworkId, Date, Message, StatusId));
                }
            }
            reader.Close();
            connection.Close();
            return answerDTOs;
        }

        public AnswerDTO SelectById(int id)
        {
            var answerDTO = new AnswerDTO();
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

            string sqlExpression = "Answer_SelectById";
            var command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            var idParameter = new SqlParameter("@Id", id);
            command.Parameters.Add(idParameter);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) 
            {
                reader.Read();
                int Id = (int)reader["Id"];
                int UserId = (int)reader["UserId"];
                int ResourceId = (int)reader["ResourceId"];
                int HomeworkId = (int)reader["HomeworkId"];
                DateTime Date = (DateTime)reader["Date"];
                string Message = (string)reader["Message"];
                int StatusId = (int)reader["StatusId"];
                answerDTO = new AnswerDTO(Id, UserId, ResourceId, HomeworkId, Date, Message, StatusId));
            }
            reader.Close();
            connection.Close();
            return answerDTO;
        }
    }
}

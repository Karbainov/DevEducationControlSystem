using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using DevEducationControlSystem.DBL.DTO;
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
                answerDTO = new AnswerDTO(Id, UserId, ResourceId, HomeworkId, Date, Message, StatusId);
            }
            reader.Close();
            connection.Close();
            return answerDTO;
        }
        public void Add(int UserId, int? ResourceId, int HomeworkId, DateTime Date, string Message, int StatusId)
        {
            string expr = "[Answer_Add]";
            var value = new { UserId = UserId, ResourceId = ResourceId, HomeworkId = HomeworkId, Date = Date, Message = Message, StatusId = StatusId };

            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int id)
        {
            string expr = "[Answer_Delete]";
            var value = new { Id = id };

            using (var connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(int Id, int UserId, int ResourceId, int HomeworkId, DateTime Date, string Message, int StatusId)
        {
            string expr = "[Answer_Update]";
            var value = new { Id = Id, UserId = UserId, ResourceId = ResourceId, HomeworkId = HomeworkId, Date = Date, Message = Message, StatusId = StatusId };

            using (var connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public List<AnswerExpandedDTO> SelectAllAnswersByHomeworkIdAndGroupId(int homeworkId, int groupId)
        {
            string expr = "[SelectAllAnswersByHomeworkIdAndGroupId]";
            var value = new { HomeworkId = homeworkId, GroupId = groupId };

            using (var connection = SqlServerConnection.GetConnection())
            {
               return connection.Query<AnswerExpandedDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<AnswerExpandedDTO>();
            }
        }
        public AnswerByUserIdAndHomeworkIdDTO SelectAnswerByUserIdAndHomeworkId(int userId, int homeworkId)
        {
          string expr = "[SelectAnswerByUserIdAndHomeworkId]";
          var value = new { UserId = userId, HomeworkId = homeworkId };
          using (var connection = SqlServerConnection.GetConnection())
          {
            return connection.QuerySingle<AnswerByUserIdAndHomeworkIdDTO>(expr, value, commandType: CommandType.StoredProcedure);
          }
        }
        public AnswerAndStatusAnswerDTO SelectAnswerAndStatusAnswerById(int answerId)
        {
          string expr = "[SelectAnswerAndStatusAnswerById]";
          var value = new { AnswerId = answerId };
          using (var connection = SqlServerConnection.GetConnection())
          {
            return connection.QuerySingle<AnswerAndStatusAnswerDTO>(expr, value, commandType: CommandType.StoredProcedure);
          }
        }
    }
}

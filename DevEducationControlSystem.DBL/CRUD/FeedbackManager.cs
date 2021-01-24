using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Dapper;
using DevEducationControlSystem.DBL.DTO.Base;
using System.Data;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class FeedbackManager
    {
        
        private string _connectionString;

        public FeedbackManager()
        {
            _connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test; User Id = devEd; Password = qqq!11";
            
        }
        public List<FeedbackDTO> Select()
        {
            var FeedbackDTOs = new List<FeedbackDTO>();
            string expr = "[Feedback_Select]";
            using (var connection = new SqlConnection(_connectionString))
            {
                FeedbackDTOs = connection.Query<FeedbackDTO>(expr, commandType: CommandType.StoredProcedure).AsList();
            }

            return FeedbackDTOs;
        }
        public FeedbackDTO SelectById(int id)
        {
            var FeedbackDTO = new FeedbackDTO();
            var connection = new SqlConnection (_connectionString);

            connection.Open();

            string sqlExpression = "EXEC Feedback_SelectById " + id;
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            using SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            FeedbackDTO.Id = (int)reader["Id"];
            FeedbackDTO.UserId = (int)reader["UserId"];
            FeedbackDTO.LessonId = (int)reader["LessonId"];
            FeedbackDTO.Rate = (int)reader["Rate"];
            FeedbackDTO.Message = (string)reader["Message"];

            reader.Close();
            connection.Close();

            return FeedbackDTO;
        }


        public void Update(int id)
        {
            string expr = "[Feedback_Update]";
            var value = new { Id = id };
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int id)
        {
            string expr = "[Feedback_Delete]";
            var value = new { Id = id };
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Add(int userId, int lessonId, int rate, string message)
        {
            string expr = "[Feedback_Add]";
            var value = new { UserId = userId, LessonId = lessonId, Rate = rate, Message = message, };
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

    }
}



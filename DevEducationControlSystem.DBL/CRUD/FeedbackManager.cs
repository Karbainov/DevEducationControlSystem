using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DevEducationControlSystem.DBL.DTO.Base;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class FeedbackManager
    {
        private SqlConnection connection;

        public FeedbackManager()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test; User Id = devEd; Password = qqq!11";
            connection = new SqlConnection(connectionString);
        }
        public List<FeedbackDTO> Select()
        {
            var FeedbackDTOs = new List<FeedbackDTO>();

            connection.Open();

            string sqlExpression = "EXEC Feedback_Select";
            SqlCommand command = new SqlCommand(sqlExpression, connection);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var FeedbackDTO = new FeedbackDTO();

                    FeedbackDTO.Id = (int)reader["Id"];
                    FeedbackDTO.UserId = (int)reader["UserId"];
                    FeedbackDTO.LessonId = (int)reader["LessonId"];
                    FeedbackDTO.Rate = (int)reader["Rate"];
                    FeedbackDTO.Message = (string)reader["Message"];

                    FeedbackDTOs.Add(FeedbackDTO);
                }
            }

            reader.Close();
            connection.Close();

            return FeedbackDTOs;
        }

        public FeedbackDTO SelectById(int id)
        {
            var FeedbackDTO = new FeedbackDTO();

            connection.Open();

            string sqlExpression = "EXEC Feedback_SelectById " + id;
            SqlCommand command = new SqlCommand(sqlExpression, connection);


            SqlDataReader reader = command.ExecuteReader();

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
    }
}



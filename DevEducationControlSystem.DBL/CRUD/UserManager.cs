using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class UserManager
    {
        public SqlConnection ConnectToDB()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
        public List<LessonAndFeedbackDTO> SelectLessonsAndFeedbackByUserId(int id)
        {
            var lessonsAndFeedbacks = new List<LessonAndFeedbackDTO>();
            string expr = "[SelectLessonsAndFeedbackByUserId]";
            var value = new {UserId = id };

            using (var connection = ConnectToDB())
            {
                lessonsAndFeedbacks = connection.Query<LessonAndFeedbackDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<LessonAndFeedbackDTO>(); ;
            }
            return lessonsAndFeedbacks;
        }

        public void UpdateUserProfile(int userId, string password, string phone, string email, string profileImage)
        {
            string expr = "[UpdateUserProfile]";
            var values = new { UserId = userId, NewPassword = password, NewPhone = phone, NewEmail = email, NewProfileImage = profileImage };
            using (var connection = ConnectToDB())
            {
                connection.Query(expr, values, commandType CommandType.StoredProcedure);
            }
        }
    }
}

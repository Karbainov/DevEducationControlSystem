using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DevEducationControlSystem.DBL.DTO.Base;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class LessonManager
    {
        public SqlConnection ConnectToBD()
        {
            string connectionString = @"Data Source = 80.78.240.16; Initial Catalog= DevEdControl.Test; User Id=devEd; Password=qqq!11";
            var connection = new SqlConnection(connectionString);
            return connection;
        }

        public List<LessonDTO> Select()
        {
            var lessons = new List<LessonDTO>();
            SqlConnection connection = ConnectToBD();
            connection.Open();

            string sqlExpression = "Lesson_Select";
            var command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = (int)reader["Id"];
                    int groupId = (int)reader["GroupId"];
                    string name = (string)reader["Name"];
                    DateTime lessonDate = (DateTime)reader["LessonDate"];
                    string comments = (string)reader["Comments"];
                    lessons.Add(new LessonDTO(id, groupId, name, lessonDate, comments));
                }
            }
            reader.Close();
            connection.Close();
            return lessons;
        }
    }
}

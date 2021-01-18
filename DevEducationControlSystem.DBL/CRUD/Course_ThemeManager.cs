using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DevEducationControlSystem.DBL.DTO.Base;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class Course_ThemeManager
    {
        private SqlConnection connection;

        public Course_ThemeManager()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test; User Id = devEd; Password = qqq!11";
            connection = new SqlConnection(connectionString);
        }
        public List<Course_ThemeDTO> Select()
        {
            var course_ThemeDTOs = new List<Course_ThemeDTO>();
            //Тут как-то заполняется
            

            return course_ThemeDTOs;
        }

        public Course_ThemeDTO SelectById(int id)
        {
            var course_ThemeDTO = new Course_ThemeDTO();
            //Тут как-то заполняется

            connection.Open();

            string sqlExpression = "EXEC Course_Theme_SelectById "+id;
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            //command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            course_ThemeDTO.CourseId = (int)reader["Id"];
            course_ThemeDTO.CourseId = (int)reader["CourseId"];
            course_ThemeDTO.ThemeId = (int)reader["ThemeId"];

            reader.Close();
            connection.Close();

            return course_ThemeDTO;
        }
    }
}

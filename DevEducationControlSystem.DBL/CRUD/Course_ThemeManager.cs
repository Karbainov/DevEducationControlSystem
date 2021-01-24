using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using DevEducationControlSystem.DBL.DTO.Base;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class Course_ThemeManager
    {
        private SqlConnection connection;
        string _connectionString;
        public Course_ThemeManager()
        {
            _connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test; User Id = devEd; Password = qqq!11";
            connection = new SqlConnection(_connectionString);
        }
        public List<Course_ThemeDTO> Select(int courseId, string themeId)
        {
            var course_ThemeDTOs = new List<Course_ThemeDTO>();
            string expr = "[Course_Theme_Select]";
            var value = new { CourseId = courseId, ThemeId = themeId };
            using (var connection = new SqlConnection(_connectionString))
            {
                course_ThemeDTOs = connection.Query<Course_ThemeDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList();
            }
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

            course_ThemeDTO.Id = (int)reader["Id"];
            course_ThemeDTO.CourseId = (int)reader["CourseId"];
            course_ThemeDTO.ThemeId = (int)reader["ThemeId"];

            reader.Close();
            connection.Close();

            return course_ThemeDTO;
        }
        public void Add(int courseId, int materialId)
        {
            string expr = "[Course_Material_Add]";
            var value = new { CourseId = courseId, MaterialId = materialId };
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }
        public void Delete(int id)
        {
            string expr = "[Course_Material_Delete]";
            var value = new { Id = id };
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }
        public void Update(int id)
        {
            string expr = "[Course_Material_Delete]";
            var value = new { Id = id };
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }
    }
}

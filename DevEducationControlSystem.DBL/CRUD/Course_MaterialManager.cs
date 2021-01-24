using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using DevEducationControlSystem.DBL.DTO.Base;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class Course_MaterialManager
    {
        private SqlConnection connection;
        string _connectionString;

        public Course_MaterialManager()
        {
            _connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test; User Id = devEd; Password = qqq!11";
            connection = new SqlConnection(_connectionString);
        }
        public List<Course_MaterialDTO> Select(int courseId, string materialId)
        {
            var course_MaterialDTOs = new List<Course_MaterialDTO>();
            string expr = "[Course_Material_Select]";
            var value = new { CourseId = courseId, MaterialId = materialId };
            using (var connection = new SqlConnection(_connectionString))
            {
                course_MaterialDTOs = connection.Query<Course_MaterialDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList();
            }
            return course_MaterialDTOs;
        }

        public Course_MaterialDTO SelectById(int id)
        {
            var course_MaterialDTO = new DTO.Base.Course_MaterialDTO();

            connection.Open();

            string sqlExpression = "EXEC Course_Material_SelectById"+id;
            SqlCommand command = new SqlCommand(sqlExpression, connection);

            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            course_MaterialDTO.Id = (int)reader["Id"];
            course_MaterialDTO.CourseId = (int)reader["CourseId"];
            course_MaterialDTO.MaterialId = (int)reader["MaterialId"];

            reader.Close();
            connection.Close();

            return course_MaterialDTO;
        }
        public void Add(int courseId, int themeId)
        {
            string expr = "[Course_Material_Add]";
            var value = new { UserId = courseId, GroupId = themeId };
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

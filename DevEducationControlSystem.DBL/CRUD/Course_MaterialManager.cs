using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DevEducationControlSystem.DBL.DTO.Base;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class Course_MaterialManager
    {
        private SqlConnection connection;

        public Course_MaterialManager()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test; User Id = devEd; Password = qqq!11";
            connection = new SqlConnection(connectionString);
        }
        public List<Course_MaterialDTO> Select()
        {
            var course_MaterialDTOs = new List<Course_MaterialDTO>();

            connection.Open();

            string sqlExpression = "EXEC Course_Material_Select";
            SqlCommand command = new SqlCommand(sqlExpression, connection);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows) // если есть данные
            {
                while (reader.Read()) // построчно считываем данные
                {
                    var course_MaterialDTO = new Course_MaterialDTO();

                    course_MaterialDTO.Id = (int)reader["Id"];
                    course_MaterialDTO.CourseId = (int)reader["CourseId"];
                    course_MaterialDTO.MaterialId = (int)reader["MaterialId"];

                    course_MaterialDTOs.Add(course_MaterialDTO);
                }
            }

            return course_MaterialDTOs;
        }

        public Course_MaterialDTO SelectById(int id)
        {
            var course_MaterialDTO = new Course_MaterialDTO();

            connection.Open();

            string sqlExpression = "EXEC Course_Material_SelectById"+id;
            SqlCommand command = new SqlCommand(sqlExpression, connection);

            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            course_MaterialDTO.Id = (int)reader["Id"];
            course_MaterialDTO.CourseId = (int)reader["CourseId"];
            course_MaterialDTO.MaterialId = (int)reader["MaterialId"];

            return course_MaterialDTO;
        }
    }
}

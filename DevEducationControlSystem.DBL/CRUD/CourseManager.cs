using Dapper;
using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class CourseManager
    {
        public SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        public List<CourseByTagNameDTO> SelectCourseByTagName(string name)
        {
            var courseByTag = new List<CourseByTagNameDTO>();
            string expr = "[SelectCourseByTagName]";
            var value = new { name };
            using (var connection = GetConnection())
            {
                return connection.Query<CourseByTagNameDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList();
            }
        }

        public List<CourseByTagIdDTO> SelectCourseByTagId(int id)
        {
            var courseByTag = new List<CourseByTagIdDTO>();
            string expr = "[SelectCourseByTagId]";
            var value = new { id };
            using (var connection = GetConnection())
            {
                return connection.Query<CourseByTagIdDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList();
            }
        }
    }
}

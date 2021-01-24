using Dapper;
using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DevEducationControlSystem.DBL
{
    public class SelectAllHomeworkByCourse_Manager
    {
        private SqlConnection _connection;
        private string expr;


        public SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            _connection = new SqlConnection(connectionString);
            return _connection;
        }


        public List<SelectAllHomeworkByCourseDTO> Get(int CourseId)
        {
            List<SelectAllHomeworkByCourseDTO> homeworskByCourse = new List<SelectAllHomeworkByCourseDTO>();
            var value = new { CourseId = CourseId };
            expr = "[SelectAllHomeworkByCourse]";

            using (_connection = GetConnection())
            {
                homeworskByCourse = _connection.Query<SelectAllHomeworkByCourseDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<SelectAllHomeworkByCourseDTO>();
            }

            return homeworskByCourse;
        }
    }
}

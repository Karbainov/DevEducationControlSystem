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
        private string _connectionString;
        private string expr;


        public SelectAllHomeworkByCourse_Manager()
        {
            _connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            expr = "[SelectAllHomeworkByCourse]";
        }


        public List<SelectAllHomeworkByCourseDTO> Get(int CourseId)
        {
            List<SelectAllHomeworkByCourseDTO> homeworskByCourse = new List<SelectAllHomeworkByCourseDTO>();
            var value = new { CourseId = CourseId };
            using (var connection = new SqlConnection(_connectionString))
            {
                homeworskByCourse = connection.Query<SelectAllHomeworkByCourseDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<SelectAllHomeworkByCourseDTO>();
            }
            return homeworskByCourse;
        }
    }
}

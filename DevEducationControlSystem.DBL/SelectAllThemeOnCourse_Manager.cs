using Dapper;
using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DevEducationControlSystem.DBL
{
    public class SelectAllThemeOnCourse_Manager
    {
        private string _connectionString;
        private SqlConnection connection;
        private string expr;

        private SqlConnection GetConnection()
        {
            _connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            connection = new SqlConnection(_connectionString);
            return connection;
        }

        public List<SelectAllThemeOnCourseDTO> Get(int ThemeId)
        {
            List<SelectAllThemeOnCourseDTO> themesByCourse = new List<SelectAllThemeOnCourseDTO>();
            var value = new { ThemeId = ThemeId };
            expr = "[SelectAllThemeOnCourse]";

            using (connection = GetConnection())
            {
                themesByCourse = connection.Query<SelectAllThemeOnCourseDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<SelectAllThemeOnCourseDTO>();
            }
            return themesByCourse;
        }
    }
}

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
        private string expr;

        public SelectAllThemeOnCourse_Manager()
        {
            _connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            expr = "[SelectAllThemeOnCourse]";
        }

        public List<SelectAllThemeOnCourseDTO> Get(int ThemeId)
        {
            List<SelectAllThemeOnCourseDTO> themesByCourse = new List<SelectAllThemeOnCourseDTO>();
            var value = new { ThemeId = ThemeId };
            using (var connection = new SqlConnection(_connectionString))
            {
                themesByCourse = connection.Query<SelectAllThemeOnCourseDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<SelectAllThemeOnCourseDTO>();
            }
            return themesByCourse;
        }
    }
}

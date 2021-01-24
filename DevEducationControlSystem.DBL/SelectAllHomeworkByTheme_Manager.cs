using Dapper;
using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DevEducationControlSystem.DBL
{
    public class SelectAllHomeworkByTheme_Manager
    {
        private string _connectionString;
        private string expr;

        public SelectAllHomeworkByTheme_Manager()
        {
            _connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            expr = "[SelectAllHomeworkByTheme]";
        }

        public List<SelectAllHomeworkByThemeDTO> Get(int ThemeId)
        {
            List<SelectAllHomeworkByThemeDTO> homeworksByTheme = new List<SelectAllHomeworkByThemeDTO>();
            var value = new { ThemeId = ThemeId };
            using (var connection = new SqlConnection(_connectionString))
            {
                homeworksByTheme = connection.Query<SelectAllHomeworkByThemeDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<SelectAllHomeworkByThemeDTO>();
            }
            return homeworksByTheme;
        }
    }
}

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
        private SqlConnection connection;
 
        private string expr;

        private SqlConnection GetConnection()
        {
            _connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            connection = new SqlConnection(_connectionString);
            return connection;
        }
        
        public List<SelectAllHomeworkByThemeDTO> Get(int ThemeId)
        {
            List<SelectAllHomeworkByThemeDTO> homeworksByTheme = new List<SelectAllHomeworkByThemeDTO>();
            var value = new { ThemeId };
            expr = "[SelectAllHomeworkByTheme]";

            using (connection = new SqlConnection(_connectionString))
            {
                homeworksByTheme = connection.Query<SelectAllHomeworkByThemeDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<SelectAllHomeworkByThemeDTO>();
            }
            return homeworksByTheme;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DevEducationControlSystem.DBL.DTO.Base;
using System.Data;
using Dapper;
using System.Linq;


namespace DevEducationControlSystem.DBL.CRUD
{
    class ThemeManager
    {
        public SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        public List<ThemeDTO> Select()
        {
            var theme = new List<ThemeDTO>();
            string sqlExpression = "[Theme_Select]";

            using (var connection = GetConnection())
            {
                theme = connection.Query<ThemeDTO>(sqlExpression, commandType: CommandType.StoredProcedure).ToList<ThemeDTO>();
            }
            return theme;
        }

        public ThemeDTO SelectById(int id)
        {
            ThemeDTO Teheme = new ThemeDTO();
            string sqlExpression = "[Theme_SelectById]";
            var value = new { Id = id };

            using (var connection = GetConnection())
            {
                var themes = connection.Query<ThemeDTO>(sqlExpression, value, commandType: CommandType.StoredProcedure).AsList<ThemeDTO>();
                if (themes.Count > 0)
                {
                    Teheme = themes[0];
                }
            }
            return Teheme;
        }

        public void Add(string name)
        {
            string sqlExpression = "[Theme_Add]";
            var value = new { Name = name };

            using (var connection = GetConnection())
            {
                connection.Query(sqlExpression, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int id)
        {
            string sqlExpression = "[Theme_Delete]";
            var value = new { Id = id };

            using (var connection = GetConnection())
            {
                connection.Query(sqlExpression, value, commandType: CommandType.StoredProcedure);
            }
        }
        public void Update(int id, string name)
        {
            string sqlExpression = "[Theme_Update]";
            var value = new { Id = id, Name = name };

            using (var connection = GetConnection())
            {
                connection.Query(sqlExpression, value, commandType: CommandType.StoredProcedure);
            }
        }

    }
}

﻿using Dapper;
using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class ThemeManager
    {
        public SqlConnection ConnectToDB()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
        public List<ThemeDTO> Select()
        {
            List<ThemeDTO> themes = new List<ThemeDTO>();
            SqlConnection connection = ConnectToDB();
            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                throw new Exception("DataBase connection failed");
            }

            string sqlExpression = "Theme_Select";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int id = (int)reader["Id"];
                            string name = (string)reader["Name"];
                            themes.Add(new ThemeDTO(id, name));
                        }
                    }
                }
            }
            finally
            {
                connection.Close();
            }
            return themes;
        }

        public ThemeDTO SelectById(int id)
        {
            ThemeDTO theme = new ThemeDTO();
            SqlConnection connection = ConnectToDB();
            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                throw new Exception("DataBase connection failed");
            }

            string sqlExpression = "Theme_SelectById";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter idParameter = new SqlParameter("@Id", id);
            command.Parameters.Add(idParameter);
            try
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int themeId = (int)reader["Id"];
                            string name = (string)reader["Name"];
                            theme = new ThemeDTO(themeId, name);
                        }
                    }
                }
            }
            finally
            {
                connection.Close();
            }
            return theme;
        }

        public List<ThemesByTagIdDTO> SelectThemesByTagId(int id)
        {
            var themesByTagId = new List<ThemesByTagIdDTO>();
            string expr = "[SelectThemesByTagId]";
            var value = new { TagId = id };

            using (var connection = ConnectToDB())
            {
                themesByTagId = connection.Query<ThemesByTagIdDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList();
            }

            return themesByTagId;
        }

        public List<ThemesByTagNameDTO> SelectThemesByTagName(string name)
        {
            var themesByTagName = new List<ThemesByTagNameDTO>();
            string expr = "[SelectThemesByTagId]";
            var value = new { TagName = name };

            using (var connection = ConnectToDB())
            {
                themesByTagName = connection.Query<ThemesByTagNameDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList();
            }

            return themesByTagName;
        }

        public void Add(string name)
        {
            string expression = "[Theme_Add]";
            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query(expression, name, commandType: CommandType.StoredProcedure);
            }
        }
        public void Delete(int themeId)
        {
            string expression = "[Theme_Delete]";
            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query(expression, themeId, commandType: CommandType.StoredProcedure);
            }
        }
        public void Update(int themeId, string name)
        {
            string expression = "[Theme_Delete]";

            var parameter = new  
            {
                themeId,
                name
            };

            using (var connection = SqlServerConnection.GetConnection())
            { 
                connection.Query(expression, parameter, commandType: CommandType.StoredProcedure);
            }
        }
    }
}

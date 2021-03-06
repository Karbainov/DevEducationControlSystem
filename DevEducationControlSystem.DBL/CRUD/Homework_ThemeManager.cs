﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DevEducationControlSystem.DBL.DTO.Base;
using Dapper;
using System.Data;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class Homework_ThemeManager
    {
       
        private static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
       
        public List<Homework_ThemeDTO> Select()
        {
            List <Homework_ThemeDTO> homeworks_themes = new List<Homework_ThemeDTO>();

            SqlConnection connection = GetConnection();

            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                throw new Exception("Connection failed");
            }

            string sqlExpression = "Homework_Theme_Select";
            SqlCommand command = new SqlCommand(sqlExpression, connection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows) // если есть данные
            {
                while (reader.Read()) // пока read==true читаем строку
                {
                    
                    int Id = (int)reader["Id"];
                    int HomeworkId = (int)reader["HomeworkId"];
                    int ThemeId = (int)reader["ThemeId"];
                    homeworks_themes.Add(new Homework_ThemeDTO(Id, HomeworkId, ThemeId));
                }
            }

            reader.Close();
            connection.Close();

            return homeworks_themes;
        }

        public Homework_ThemeDTO SelectById(int id)
        {
            Homework_ThemeDTO homework_theme = new Homework_ThemeDTO();

            SqlConnection connection = GetConnection();

            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                throw new Exception("Connection failed");
            }

            string sqlExpression = "Homework_SelectById";
            SqlCommand command = new SqlCommand(sqlExpression, connection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };

            SqlParameter idParameter = new SqlParameter("@Id", id);
            command.Parameters.Add(idParameter);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) // если есть данные
            {
                while (reader.Read()) // пока read==true читаем строку
                {

                    int Id = (int)reader["Id"];
                    int HomeworkId = (int)reader["HomeworkId"];
                    int ThemeId = (int)reader["ThemeId"];

                    homework_theme = new Homework_ThemeDTO(Id, HomeworkId, ThemeId);
                }
            }
            reader.Close();
            connection.Close();
            return homework_theme;
        }

        public void Add(int homeworkId, int themeId)
        {
            string sqlExpression = "[Homework_Theme_Add]";
            var values = new { HomeworkId = homeworkId, ThemeId = themeId };

            using var connection = new SqlConnection(GetConnection().ConnectionString);
            connection.Query(sqlExpression, values, commandType: CommandType.StoredProcedure);
        }

        public void Delete(int id)
        {
            string sqlExpression = "[Homework_Theme_Delete]";
            var values = new { Id = id };

            using var connection = new SqlConnection(GetConnection().ConnectionString);
            connection.Query(sqlExpression, values, commandType: CommandType.StoredProcedure);
        }
               
        public void Update(int id, int homeworkId, int themeId)
        {
            string sqlExpression = "[Homework_Theme_Update]";
            var values = new { Id = id, HomeworkId = homeworkId, ThemeId = themeId };

            using var connection = new SqlConnection(GetConnection().ConnectionString);
            connection.Query(sqlExpression, values, commandType: CommandType.StoredProcedure);
        }
    }
}

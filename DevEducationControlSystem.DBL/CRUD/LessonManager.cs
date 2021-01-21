﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DevEducationControlSystem.DBL.DTO.Base;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class LessonManager
    {
        public SqlConnection ConnectToBD()
        {
            string connectionString = @"Data Source = 80.78.240.16; Initial Catalog= DevEdControl.Test; User Id=devEd; Password=qqq!11";
            var connection = new SqlConnection(connectionString);
            return connection;
        }

        public List<LessonDTO> Select()
        {
            var lessons = new List<LessonDTO>();
            SqlConnection connection = ConnectToBD();
            
            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                throw new Exception("DataBase connection failed");
            }

            string sqlExpression = "Lesson_Select";
            var command = new SqlCommand(sqlExpression, connection);
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
                            int groupId = (int)reader["GroupId"];
                            string name = (string)reader["Name"];
                            DateTime lessonDate = (DateTime)reader["LessonDate"];
                            string comments = (string)reader["Comments"];
                            lessons.Add(new LessonDTO(id, groupId, name, lessonDate, comments));
                        }
                    }
                    reader.Close();
                }
            }
            finally
            {
                connection.Close();
            }
            return lessons;
        }

        public LessonDTO SelectById(int id)
        {
            var lesson = new LessonDTO();
            SqlConnection connection = ConnectToBD();
            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                throw new Exception("DataBase connection failed");
            }

            string sqlExpression = "Lesson_SelectById";
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
                            int _id = (int)reader["Id"];
                            int groupId = (int)reader["GroupId"];
                            string name = (string)reader["Name"];
                            DateTime lessonDate = (DateTime)reader["LessonDate"];
                            string comments = (string)reader["Comments"];
                            lesson = new LessonDTO(_id, groupId, name, lessonDate, comments);
                        }
                    }
                    reader.Close();
                }
            }
            finally
            {
                connection.Close();
            }
            return lesson;
        }

    }
}
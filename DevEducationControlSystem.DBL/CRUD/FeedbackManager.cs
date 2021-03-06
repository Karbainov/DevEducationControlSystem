﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Dapper;
using DevEducationControlSystem.DBL.DTO.Base;
using System.Data;
using DevEducationControlSystem.DBL.DTO.WholeCourseFeedback;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class FeedbackManager
    {
        
        private string _connectionString;

        public FeedbackManager()
        {
            _connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test; User Id = devEd; Password = qqq!11";
            
        }
        public List<FeedbackDTO> Select()
        {
            var FeedbackDTOs = new List<FeedbackDTO>();
            string expr = "[Feedback_Select]";
            using (var connection = new SqlConnection(_connectionString))
            {
                FeedbackDTOs = connection.Query<FeedbackDTO>(expr, commandType: CommandType.StoredProcedure).AsList();
            }

            return FeedbackDTOs;
        }
        public FeedbackDTO SelectById(int id)
        {
            var FeedbackDTO = new FeedbackDTO();
            var connection = new SqlConnection (_connectionString);

            connection.Open();

            string sqlExpression = "EXEC Feedback_SelectById " + id;
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            using SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            FeedbackDTO.Id = (int)reader["Id"];
            FeedbackDTO.UserId = (int)reader["UserId"];
            FeedbackDTO.LessonId = (int)reader["LessonId"];
            FeedbackDTO.Rate = (int)reader["Rate"];
            FeedbackDTO.Message = (string)reader["Message"];

            reader.Close();
            connection.Close();

            return FeedbackDTO;
        }

        public FeedbackDTO SelectFeedbackByUserIdAndLessonId(int userId, int lessonId)
        {
            var feedback = new FeedbackDTO();
            string expression = "SelectFeedbackByUserIdAndLessonId";
            var parameter = new { UserId = userId, LessonId = lessonId};
            using (var connection = SqlServerConnection.GetConnection())
            {
                feedback = connection.QuerySingleOrDefault<FeedbackDTO>(expression, parameter, commandType: CommandType.StoredProcedure);
            }
            return feedback;
        }


        public void Update(int id, int userId, int lessonId, int rate, string message)
        {
            string expr = "[Feedback_Update]";
            var value = new { Id = id, UserId = userId, LessonId = lessonId, Rate = rate, Message = message };
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int id)
        {
            string expr = "[Feedback_Delete]";
            var value = new { Id = id };
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Add(int userId, int lessonId, int rate, string message)
        {
            string expr = "[Feedback_Add]";
            var value = new { UserId = userId, LessonId = lessonId, Rate = rate, Message = message, };
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public List<FeedbackDTO> SelectByUserId(int userId)
        {
            string expr = "[Feedback_SelectByUserId]";
            var value = new { UserId = userId };
            using (var connection = SqlServerConnection.GetConnection())
            {
                return connection.Query<FeedbackDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<FeedbackDTO>();
            }
        }

        public Dictionary<int, WholeCourseFeedbackDTO> GetFeedbackByCourseId(int courseId)
        {
            Dictionary<int, WholeCourseFeedbackDTO> wholeCourseFeedbackDTOs = new Dictionary<int, WholeCourseFeedbackDTO>(); ;
            string expression = "[GetWholeCourseFeedback]";
            var parameter = new { CourseId = courseId };
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query<WholeCourseFeedbackDTO, ThemeFromCourseDTO, WholeCourseFeedbackDTO>
                    (expression, (wholeCourseFeedback, themeFromCourseFeedback) =>
                    {

                        WholeCourseFeedbackDTO wholeCourseFeedbackDTO;

                        if (!wholeCourseFeedbackDTOs.TryGetValue(wholeCourseFeedback.FeedbackId, out wholeCourseFeedbackDTO))
                        {
                            wholeCourseFeedbackDTO = wholeCourseFeedback;
                            wholeCourseFeedbackDTOs.Add(wholeCourseFeedback.FeedbackId, wholeCourseFeedbackDTO);
                        }

                        if (wholeCourseFeedbackDTO.ThemeFromCourseFeedbackDTOs == null)
                        {
                            wholeCourseFeedbackDTO.ThemeFromCourseFeedbackDTOs = new List<ThemeFromCourseDTO>();
                        }
                        wholeCourseFeedbackDTO.ThemeFromCourseFeedbackDTOs.Add(themeFromCourseFeedback);

                        return wholeCourseFeedbackDTO;
                    },
                    parameter, commandType: CommandType.StoredProcedure, splitOn: "ThemeId");
            }
            return wholeCourseFeedbackDTOs;
        }


    }
}



        
﻿using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;
using DevEducationControlSystem.DBL.DTO;
using System.Linq;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class GroupManager
    {
        public SqlConnection ConnectToDB()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
        public List<GroupDTO> Select()
        {
            List<GroupDTO> groups = new List<GroupDTO>();
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

            string sqlExpression = "Group_Select";
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
                            int statusId = (int)reader["StatusId"];
                            int courseId = (int)reader["CourseId"];
                            int cityId = (int)reader["CityId"];
                            string name = (string)reader["Name"];
                            DateTime startDate = (DateTime)reader["StartDate"];
                            groups.Add(new GroupDTO(id, statusId, courseId, cityId, name, startDate));
                        }
                    }
                }
            }
            finally
            {
                connection.Close();

            }
            return groups;
        }

        public GroupDTO SelectById(int id)
        {
            GroupDTO group = null;
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

            string sqlExpression = "Group_SelectById";
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
                            int groupId = (int)reader["Id"];
                            int statusId = (int)reader["StatusId"];
                            int courseId = (int)reader["CourseId"];
                            int cityId = (int)reader["CityId"];
                            string name = (string)reader["Name"];
                            DateTime startDate = (DateTime)reader["StartDate"];
                            group = new GroupDTO(groupId, statusId, courseId, cityId, name, startDate);
                        }
                    }
                }
            }
            finally
            {
                connection.Close();
            }
            return group;
        }

        public void Add(int statusId, int courseId, int cityId,string name, DateTime startDate)
        {
            string expr = "[Group_Add]";
            var value = new {StatusId = statusId, CourseId = courseId, CityId = cityId, Name = name, StartDate = startDate };

            using (var connection = ConnectToDB())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int id)
        {
            string expr = "[Group_Delete]";
            var value = new { Id = id };

            using (var connection = ConnectToDB())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(int id, int statusId, int courseId, int cityId, string name, DateTime startDate)
        {
            string expr = "[Group_Update]";
            var value = new { Id = id, StatusId = statusId, CourseId = courseId, CityId = cityId, Name = name, StartDate = startDate };

            using (var connection = ConnectToDB())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public GroupWithCityAndStatusAndCourseDTO SelectGroupWithCityAndStatusAndCourseById(int groupId)
        {
           
            string expr = "[SelectGroupWithCityAndStatusAndCourseById]";
            var value = new {groupId};

            using (var connection = SqlServerConnection.GetConnection())
            {
                return connection.QuerySingle<GroupWithCityAndStatusAndCourseDTO>(expr, value, commandType: CommandType.StoredProcedure);
            }
        }
        public List<PassedThemesAndHomeworksAndAnswerByStudentIdDTO> SelectPassedThemesAndHomeworksAndAnswerByStudentId(int studentId)
        {
          string expr = "[SelectPassedThemesAndHomeworksByStudentId]";
          var value = new { StudentID = studentId };
          using (var connection = SqlServerConnection.GetConnection())
          {
            return connection.Query<PassedThemesAndHomeworksAndAnswerByStudentIdDTO>(expr, value, commandType: CommandType.StoredProcedure).ToList<PassedThemesAndHomeworksAndAnswerByStudentIdDTO>();
          }
        }
        public List<StudentDTO> SelectStudentsByGroupId(int groupId)
        {
          string expr = "[SelectStudentsByGroupId]";
          var value = new { GroupId = groupId };
          using (var connection = SqlServerConnection.GetConnection())
          {
            return connection.Query<StudentDTO>(expr, value, commandType: CommandType.StoredProcedure).ToList<StudentDTO>();
          }
        }
    }
}

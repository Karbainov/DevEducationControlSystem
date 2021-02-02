using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.DTO.Base;
using System.Linq;

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

            string sqlExpression = "[Lesson_Select]";
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

            string sqlExpression = "[Lesson_SelectById]";
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

        public void Add(int groupId, string name, DateTime lessonDate, string comments)
        {
            string expr = "[Lesson_Add]";
            var value = new { GroupId = groupId, Name = name, LessonDate = lessonDate, Comments = comments };
            using (var connection = ConnectToBD())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int id)
        {
            string expr = "[Lesson_Delete]";
            var value = new { Id = id};
            using (var connection = ConnectToBD())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(int id, int groupId, string name, DateTime lessonDate, string comments)
        {
            string expr = "[Lesson_Update]";
            var value = new { Id = id, GroupId = groupId, Name = name, LessonDate = lessonDate, Comments = comments };
            using (var connection = ConnectToBD())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public List<LessonAttendanceDTO> SelectLessonAttendanceByGroupId(int groupId)
        {
            string expr = "[SelectLessonAttendanceByGroupId]";
            var value = new { groupId };

            List<LessonAttendanceDTO> lessons = new List<LessonAttendanceDTO>();

            using (var connection = SqlServerConnection.GetConnection())
            {

                connection.Query<LessonAttendanceDTO, AttendanceDTO, LessonAttendanceDTO>(expr,
                (lessonAttendance, attendance) =>
                {
                    LessonAttendanceDTO tmpLesson = null;

                    foreach (var r in lessons)
                    {
                        if (r.LessonId == lessonAttendance.LessonId)
                        {
                            tmpLesson = r;
                            break;
                        }
                    }
                    if (tmpLesson == null)
                    {
                        tmpLesson = lessonAttendance;
                        lessons.Add(tmpLesson);
                    }

                    if(tmpLesson.Attendances == null)
                    {
                        tmpLesson.Attendances = new List<AttendanceDTO>();
                    }
                    tmpLesson.Attendances.Add(attendance);

                    return tmpLesson;
                },
                value,
                splitOn: "Id",
                commandType: CommandType.StoredProcedure);
            }

            return lessons;
        }

        public List<PassedLessonByStudentIdDTO> SelectPassedLessonByStudentId(int studentId)
        {
            var passedLesson = new List<PassedLessonByStudentIdDTO>();
            
            string expression = "[SelectPassedLessonByStudentId]";
            var parameter = new { UserId = studentId };

            using (var connection = SqlServerConnection.GetConnection())
            {
                passedLesson = connection.Query<PassedLessonByStudentIdDTO>(expression, parameter, commandType: CommandType.StoredProcedure).ToList<PassedLessonByStudentIdDTO>();
            }
            return passedLesson;
        }

    }
}

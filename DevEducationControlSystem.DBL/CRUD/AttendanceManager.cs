using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Dapper;
using DevEducationControlSystem.DBL.DTO.Base;
using System.Data;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class AttendanceManager
    {
        
        private string _connectionString;

        public AttendanceManager()
        {
            _connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test; User Id = devEd; Password = qqq!11";
            
        }
        public List<AttendanceDTO> Select()
        {
            var AttendanceDTOs = new List<AttendanceDTO>();
            string expr = "[Attendance_Select]";
            using (var connection = new SqlConnection(_connectionString))
            {
                AttendanceDTOs = connection.Query<AttendanceDTO>(expr, commandType: CommandType.StoredProcedure).AsList();
            }

            return AttendanceDTOs;
        }
        public AttendanceDTO SelectById(int id)
        {
            var AttendanceDTO = new AttendanceDTO();
            var connection = new SqlConnection(_connectionString);

            connection.Open();

            string sqlExpression = "EXEC Attendance_SelectById " + id;
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            using SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            AttendanceDTO.Id = (int)reader["Id"];
            AttendanceDTO.UserId = (int)reader["UserId"];
            AttendanceDTO.LessonId = (int)reader["LessonId"];
            AttendanceDTO.IsPresent = (bool)reader["IsPresent"];

            reader.Close();
            connection.Close();

            return AttendanceDTO;
        }


        public void Update(int id)
        {
            string expr = "[Attendance_Update]";
            var value = new { Id = id };
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int id)
        {
            string expr = "[Attendance_Delete]";
            var value = new { Id = id };
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Add(int userId, int lessonId, bool isPresent)
        {
            string expr = "[Attendance_Add]";
            var value = new { UserId = userId, LessonId = lessonId, IsPresent = isPresent,};
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

       
    }
}

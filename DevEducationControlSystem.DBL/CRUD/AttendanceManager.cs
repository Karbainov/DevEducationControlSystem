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
      
        public List<AttendanceDTO> Select()
        {
            var AttendanceDTOs = new List<AttendanceDTO>();
            string expr = "[Attendance_Select]";
            using (var connection = SqlServerConnection.GetConnection())
            {
                AttendanceDTOs = connection.Query<AttendanceDTO>(expr, commandType: CommandType.StoredProcedure).AsList();
            }

            return AttendanceDTOs;
        }
        public AttendanceDTO SelectById(int id)
        {
            var AttendanceDTO = new AttendanceDTO();
            var connection = SqlServerConnection.GetConnection();

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


        public void Update(int id, int userId, int lessonId, bool isPresent)
        {
            string expr = "[Attendance_Update]";
            var value = new { Id = id,
                UserId = userId,
                LessonId = lessonId,
                IsPresent = isPresent
            };
            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateIsPresent(int id, bool isPresent)
        {
            string expr = "[UpdateAttendanceIsPresent]";
            var value = new
            {
                Id = id,
                IsPresent = isPresent
            };
            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int id)
        {
            string expr = "[Attendance_Delete]";
            var value = new { Id = id };
            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public int Add(int userId, int lessonId, bool isPresent)
        {
            int attendanceId = -1;
            string expr = "[Attendance_Add]";
            var value = new { UserId = userId, LessonId = lessonId, IsPresent = isPresent};
            using (var connection = SqlServerConnection.GetConnection())
            {
               attendanceId = connection.QuerySingle<int>(expr, value, commandType: CommandType.StoredProcedure);
            }
            return attendanceId;
        }

       
    }
}

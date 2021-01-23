using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DevEducationControlSystem.DBL.DTO.Base;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class AttendanceManager
    {
        private SqlConnection connection;

        public AttendanceManager()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test; User Id = devEd; Password = qqq!11";
            connection = new SqlConnection(connectionString);
        }
        public List<AttendanceDTO> Select()
        {
            var AttendanceDTOs = new List<AttendanceDTO>();

            connection.Open();

            string sqlExpression = "EXEC Attendance_Select";
            SqlCommand command = new SqlCommand(sqlExpression, connection);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var AttendanceDTO = new AttendanceDTO();

                    AttendanceDTO.Id = (int)reader["Id"];
                    AttendanceDTO.UserId = (int)reader["UserId"];
                    AttendanceDTO.LessonId = (int)reader["LessonId"];
                    AttendanceDTO.IsPresent = (bool)reader["IsPresent"];
                    
                    AttendanceDTOs.Add(AttendanceDTO);
                }
            }

            reader.Close();
            connection.Close();

            return AttendanceDTOs;
        }

        public AttendanceDTO SelectById(int id)
        {
            var AttendanceDTO = new AttendanceDTO();

            connection.Open();

            string sqlExpression = "EXEC Attendance_SelectById " + id;
            SqlCommand command = new SqlCommand(sqlExpression, connection);


            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            AttendanceDTO.Id = (int)reader["Id"];
            AttendanceDTO.UserId = (int)reader["UserId"];
            AttendanceDTO.LessonId = (int)reader["LessonId"];
            AttendanceDTO.IsPresent = (bool)reader["IsPresent"];

            reader.Close();
            connection.Close();
            return AttendanceDTO;


        }
    }
}

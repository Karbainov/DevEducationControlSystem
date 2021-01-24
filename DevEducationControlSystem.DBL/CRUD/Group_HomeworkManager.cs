using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using System.Data;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class Group_HomeworkManager
    {
        public SqlConnection ConnectToBD()
        {
            string connectionString = @"Data Source = 80.78.240.16; Initial Catalog= DevEdControl.Test; User Id=devEd; Password=qqq!11";
            var connection = new SqlConnection(connectionString);
            return connection;
        }

        public List<Group_HomeworkDTO> Select()
        {
            var Group_Homeworks = new List<Group_HomeworkDTO>();
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

            string sqlExpression = "Group_Homework_Select";
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
                            int homeworkId = (int)reader["HomeworkId"];
                            DateTime startDate = (DateTime)reader["StartDate"];
                            DateTime deadLine = (DateTime)reader["DeadLine"];
                            Group_Homeworks.Add(new Group_HomeworkDTO(id, groupId, homeworkId, startDate, deadLine));
                        }
                    }
                    reader.Close();
                }
            }
            finally
            {
                connection.Close();
            }
            return Group_Homeworks;
        }

        public Group_HomeworkDTO SelectById(int id)
        {
            var Group_Homework = new Group_HomeworkDTO();
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

            string sqlExpression = "Group_Homework_SelectById";
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
                            int homeworkId = (int)reader["HomeworkId"];
                            DateTime startDate = (DateTime)reader["StartDate"];
                            DateTime deadLine = (DateTime)reader["DeadLine"];
                            Group_Homework = new Group_HomeworkDTO(_id, groupId, homeworkId, startDate, deadLine);
                        }
                    }
                    reader.Close();
                }
            }
            finally
            {
                connection.Close();
            }
            return Group_Homework;
        }

        public void Delete(int id)
        {
            string expr = "Group_Homework_Delete";
            var value = new { Id = id };
            using (SqlConnection connection = ConnectToBD())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(int id, string name)
        {
            string expr = "Group_Homework_Update";
            var value = new { Id = id, Name = name };
            using (var connection = ConnectToBD())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DevEducationControlSystem.DBL.DTO.Base;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class HomeworkManager
    {
       
        private static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
       
        public List<HomeworkDTO> Select()
        {
            List <HomeworkDTO> homeworks = new List<HomeworkDTO>();

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

            string sqlExpression = "Homework_Select";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows) // если есть данные
            {
                while (reader.Read()) // пока read==true читаем строку
                {
                    
                    int Id = (int)reader["Id"];
                    int ResourceId = (int)reader["ResourceId"];
                    string Name = (string)reader["Name"];
                    string Description = (string)reader["Description"];
                    string IsDeleted = (string)reader["IsDeleted"];
                    string IsSolutionRequired = (string)reader["IsSolutionRequired"];
                   
                    homeworks.Add(new HomeworkDTO(Id, ResourceId, Name, Description, IsDeleted, IsSolutionRequired));
                }
            }

            reader.Close();
            connection.Close();

            return homeworks;
        }

        public HomeworkDTO SelectById(int id)
        {
            HomeworkDTO homework = new HomeworkDTO();

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
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter idParameter = new SqlParameter("@Id", id);
            command.Parameters.Add(idParameter);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) // если есть данные
            {
                while (reader.Read()) // пока read==true читаем строку
                {

                    int Id = (int)reader["Id"];
                    int ResourceId = (int)reader["ResourceId"];
                    string Name = (string)reader["Name"];
                    string Description = (string)reader["Description"];
                    string IsDeleted = (string)reader["IsDeleted"];
                    string IsSolutionRequired = (string)reader["IsSolutionRequired"];

                    homework = new HomeworkDTO(Id, ResourceId, Name, Description, IsDeleted, IsSolutionRequired);
                }
            }

            reader.Close();
            connection.Close();
            return homework;
        }
    }
}

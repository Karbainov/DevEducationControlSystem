using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DevEducationControlSystem.DBL.DTO.Base;
using System.Data;
using Dapper;
using System.Linq;

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

        //public List<HomeworkDTO> Select()
        //{
        //    List<HomeworkDTO> homeworks = new List<HomeworkDTO>();

        //    SqlConnection connection = GetConnection();

        //    try
        //    {
        //        connection.Open();
        //    }
        //    catch
        //    {
        //        connection.Close();
        //        throw new Exception("Connection failed");
        //    }

        //    string sqlExpression = "Homework_Select";
        //    SqlCommand command = new SqlCommand(sqlExpression, connection);
        //    command.CommandType = System.Data.CommandType.StoredProcedure;

        //    SqlDataReader reader = command.ExecuteReader();

        //    if (reader.HasRows) // если есть данные
        //    {
        //        while (reader.Read()) // пока read==true читаем строку
        //        {

        //            int Id = (int)reader["Id"];
        //            int ResourceId = (int)reader["ResourceId"];
        //            string Name = (string)reader["Name"];
        //            string? Description = (string?)reader["Description"];
        //            bool IsDeleted = (bool)reader["IsDeleted"];
        //            bool IsSolutionRequired = (bool)reader["IsSolutionRequired"];

        //            homeworks.Add(new HomeworkDTO(Id, ResourceId, Name, Description, IsDeleted, IsSolutionRequired));
        //        }
        //    }

        //    reader.Close();
        //    connection.Close();

        //    return homeworks;
        //}

        public List<HomeworkDTO> Select()
        {
            var  hw = new List <HomeworkDTO>();
            string sqlExpression = "[Homework_Select]";
            

            using (var connection = new SqlConnection(GetConnection().ConnectionString))
            {
                hw = connection.Query<HomeworkDTO>(sqlExpression, commandType: CommandType.StoredProcedure).ToList<HomeworkDTO>();
            }
            return hw;
        }

        public HomeworkDTO SelectById (int id)
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
                    bool IsDeleted = (bool)reader["IsDeleted"];
                    bool IsSolutionRequired = (bool)reader["IsSolutionRequired"];

                    homework = new HomeworkDTO(Id, ResourceId, Name, Description, IsDeleted, IsSolutionRequired);
                }
            }
            reader.Close();
            connection.Close();
            return homework;
        }

        public void Add (int resourceId, string name, string description, string isSolutionRequired)
        {
            string sqlExpression = "[Homework_Add]";
            var values = new { ResourceId = resourceId, Name = name, Description = description, IsSolutionRequired = isSolutionRequired };

            using (var connection = new SqlConnection(GetConnection().ConnectionString))
            {
                connection.Query(sqlExpression, values, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete (int id)
        {
            string sqlExpression = "[Homework_Delete]";
            var values = new { Id = id };

            using (var connection = new SqlConnection(GetConnection().ConnectionString))
            {
                connection.Query(sqlExpression, values, commandType: CommandType.StoredProcedure);
            }
        }

        public void SoftDelete(int id)
        {
            string sqlExpression = "[Homework_SoftDelete]";
            var values = new { Id = id };

            using (var connection = new SqlConnection(GetConnection().ConnectionString))
            {
                connection.Query(sqlExpression, values, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update (int id, int resourceId, string name, string description, string isDeleted,  string isSolutionRequired)
        {
            string sqlExpression = "[Homework_Update]";
            var values = new { Id = id, ResourceId = resourceId, Name = name, Description = description, IsDeleted = isDeleted, IsSolutionRequired = isSolutionRequired };

            using (var connection = new SqlConnection(GetConnection().ConnectionString))
            {
                connection.Query(sqlExpression, values, commandType: CommandType.StoredProcedure);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DevEducationControlSystem.DBL.DTO.Base;
using Dapper;
using System.Data;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class GroupStatusManager
    {
        public SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        public List<GroupStatusDTO> Select()
        {
            List<GroupStatusDTO> groupStatusAll = new List<GroupStatusDTO>();
            SqlConnection connection = GetConnection();
            try
            {
                connection.Open();
            }
            catch
            {
                throw new Exception("Failed to connect");
            }

            string SqlExpression = "GroupStatus_Select";
            SqlCommand command = new SqlCommand(SqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) // если есть данные
            {
                while (reader.Read()) // построчно считываем данные
                {
                    int id = (int)reader["id"];
                    string name = (string)reader["Name"];
                    
                    groupStatusAll.Add(new GroupStatusDTO(id, name));
                }
            }
            reader.Close();
            connection.Close();
            return groupStatusAll;
        }

        public GroupStatusDTO SelectById(int Id)
        {
            GroupStatusDTO groupStatus = new GroupStatusDTO();
            SqlConnection connection = GetConnection();
            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                throw new Exception("Failed to connect");
            }

            string SqlExpression = "GroupStatus_SelectById";
            SqlCommand command = new SqlCommand(SqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter idParam = new SqlParameter("@Id", Id);
            command.Parameters.Add(idParam);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) // если есть данные
            {
                while (reader.Read()) // построчно считываем данные
                {
                    int id = (int)reader["id"];
                    string name = (string)reader["Name"];

                    groupStatus = new GroupStatusDTO(id, name);
                }
            }
            reader.Close();
            connection.Close();
            return groupStatus;
        }

        public void Add(string name)
        {
            string expr = "[GroupStatus_Add]";
            var value = new { Name = name };
            using (var connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int id)
        {
            string expr = "[GroupStatus_Delete]";
            var value = new { Id = id };
            using (var connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(int id, string name)
        {
            string expr = "[GroupStatus_Update]";
            var value = new { Id = id, Name = name };
            using (var connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }
    }
}

using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ConsoleApp9
{
    public class Program
    {
        static void Main(string[] args)
        {
             SqlConnection GetConnection()
            {
                string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
                SqlConnection connection = new SqlConnection(connectionString);
                return connection;
            }
            int Id = Convert.ToInt32(Console.ReadLine());
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
                    int id = (int)reader["Id"];
                    string name = (string)reader["Name"];
            Console.WriteLine($"{id}\t{name}");

                    groupStatus = new GroupStatusDTO(id, name);
                }
            }
            reader.Close();
            connection.Close();

        }
    }
}

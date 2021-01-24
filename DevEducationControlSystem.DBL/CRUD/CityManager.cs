﻿using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Dapper;
using System.Data;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class CityManager
    {

        public SqlConnection ConnectToDB()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
        public List<CityDTO> Select()
        {
            List<CityDTO> cities = new List<CityDTO>();
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

            string sqlExpression = "City_Select";
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
                            string name = (string)reader["Name"];
                            cities.Add(new CityDTO(id, name));
                        }
                    }
                }
            }
            finally
            {
            connection.Close();
            }
            return cities;
        }

        public CityDTO SelectById(int id)
        {
            CityDTO city = new CityDTO();
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

            string sqlExpression = "City_SelectById";
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
                            int cityId = (int)reader["Id"];
                            string name = (string)reader["Name"];
                            city = new CityDTO(cityId, name);
                        }
                    }
                }
            }
            finally
            {
            connection.Close();
            }
            return city;
        }

        public void Add(string name)
        {
            string expr = "[City_Add]";
            var value = new { Name = name };

            using (var connection = ConnectToDB())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int id)
        {
            string expr = "[City_Delete]";
            var value = new { Id = id };

            using (var connection = ConnectToDB())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(int id, string name)
        {
            string expr = "[City_Update]";
            var value = new {Id = id, Name = name };

            using (var connection = ConnectToDB())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }
    }
}

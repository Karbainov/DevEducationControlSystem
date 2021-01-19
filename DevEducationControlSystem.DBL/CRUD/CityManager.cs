using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class CityManager
    {

        public SqlConnection ConnectToDB()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEduTestSystem;User Id = devEd; Password = qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
        public List<CityDTO> Select()
        {
            List<CityDTO> cities = new List<CityDTO>();
            SqlConnection connection = ConnectToDB();
            connection.Open();

            string sqlExpression = "City_Select";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader reader = command.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = (int)reader["Id"];
                    string name = (string)reader["Name"];
                    cities.Add(new CityDTO(id, name));
                }
            }
            reader.Close();
            connection.Close();
            return cities;
        }

        public CityDTO SelectById(int id)
        {
            CityDTO city = new CityDTO();
            SqlConnection connection = ConnectToDB();
            connection.Open();

            string sqlExpression = "City_SelectById";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter idParameter = new SqlParameter("@Id", id);
            command.Parameters.Add(idParameter);

            SqlDataReader reader = command.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int cityId = (int)reader["Id"];
                    string name = (string)reader["Name"];
                    city = new CityDTO(cityId, name);
                }
            }
            reader.Close();
            connection.Close();
            return city;
        }
    }
}

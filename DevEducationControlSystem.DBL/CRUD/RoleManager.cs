using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DevEducationControlSystem.DBL.DTO.Base;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class RoleManager
    {
        private SqlConnection connection;

        public RoleManager()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test; User Id = devEd; Password = qqq!11";
            connection = new SqlConnection(connectionString);
        }
        public List<RoleDTO> Select()
        {
            var RoleDTOs = new List<RoleDTO>();

            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                throw new Exception("DataBase connection failed");
            }

            string sqlExpression = "EXEC Role_Select";
            SqlCommand command = new SqlCommand(sqlExpression, connection);

            try
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read()) // построчно считываем данные
                        {
                            var RoleDTO = new RoleDTO();

                            RoleDTO.Id = (int)reader["Id"];
                            RoleDTO.Name = (string)reader["Name"];

                            RoleDTOs.Add(RoleDTO);
                        }
                    }
                }
            }
            finally
            {
                connection.Close();
            }
            return RoleDTOs;

        }

        public RoleDTO SelectById(int id)
        {
            var RoleDTO = new RoleDTO();
            //Тут как-то заполняется

            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                throw new Exception("DataBase connection failed");
            }

            string sqlExpression = "EXEC Role_SelectById " + id;
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            //command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader reader = command.ExecuteReader();

            try
            {
                reader.Read();
                RoleDTO.Id = (int)reader["Id"];
                RoleDTO.Name = (string)reader["Name"];
            }
            catch
            {

            }
            finally
            {
                reader.Close();
                connection.Close();
            }

            return RoleDTO;
        }
    }
}



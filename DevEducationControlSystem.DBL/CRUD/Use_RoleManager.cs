using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DevEducationControlSystem.DBL.DTO.Base;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class User_RoleManager
    {
        private SqlConnection connection;

        public User_RoleManager()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test; User Id = devEd; Password = qqq!11";
            connection = new SqlConnection(connectionString);
        }
        public List<User_RoleDTO> Select()
        {
            var User_RoleDTOs = new List<User_RoleDTO>();

            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                throw new Exception("DataBase connection failed");
            }

            string sqlExpression = "EXEC User_Role_Select";
            SqlCommand command = new SqlCommand(sqlExpression, connection);

            try
            {
                using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read()) // построчно считываем данные
                        {
                            var User_RoleDTO = new User_RoleDTO();

                            User_RoleDTO.Id = (int)reader["Id"];
                            User_RoleDTO.UserId = (int)reader["UserId"];
                            User_RoleDTO.RoleId = (int)reader["RoleId"];

                            User_RoleDTOs.Add(User_RoleDTO);
                        }

                    }

               }
            }
            finally
            {
                connection.Close();
            }
            return User_RoleDTOs;

        }
        public User_RoleDTO SelectById(int id)
        {
            var User_RoleDTO = new User_RoleDTO();
            //Тут как-то заполняется

            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                throw new Exception("Connection ne open");
            }

            string sqlExpression = "EXEC User_Role_SelectById " + id;
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            //command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader reader = command.ExecuteReader();
            try
            {
                reader.Read();

                User_RoleDTO.Id = (int)reader["Id"];
                User_RoleDTO.UserId = (int)reader["UserId"];
                User_RoleDTO.RoleId = (int)reader["RoleId"];
            }
            finally
            {
                reader.Close();
                connection.Close();
            }


            return User_RoleDTO;
        }
        
    }
}

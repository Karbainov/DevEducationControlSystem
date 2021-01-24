using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DevEducationControlSystem.DBL.DTO.Base;
using Dapper;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class User_RoleManager
    {
        private SqlConnection connection;

        public SqlConnection ConnectToDB()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test; User Id = devEd; Password = qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
        public List<User_RoleDTO> Select()
        {
            //var User_RoleDTOs = new List<User_RoleDTO>();
            List<User_RoleDTO> User_Roles = new List<User_RoleDTO>();
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

            string sqlExpression = "User_Role_Select";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read()) // построчно считываем данные
                        {
                            var User_RoleDTO = new User_RoleDTO();

                            int id = (int)reader["Id"];
                            int userId = (int)reader["UserId"];
                            int roleId = (int)reader["RoleId"];

                            //User_RoleDTOs.Add(User_RoleDTO);
                            User_Roles.Add(User_RoleDTO);
                        }
                    }
               }
            }
            finally
            {
                connection.Close();
            }
            return User_Roles;

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
                throw new Exception("DataBase connection failed");
            }

            string sqlExpression = "User_Role_SelectById " + id;
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

        public void Add(int userId, int roleId)
        {
            string expr = "[User_Role_Add]";
            var value = new { UserId = userId, RoleId = roleId };
            //int roleIdValue -new { RoleId = roleId };
            using (var connection = ConnectToDB())
            {
                connection.Query(expr, value, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public void Delete(int id)
        {
            string expr = "[User_Role_Delete]";
            var value = new { Id = id };
            using (var connection = ConnectToDB())
            {
                connection.Query(expr, value, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public void Update(int id, int userId, int roleId)
        {
            string expr = "[User_Role_Update]";
            var value = new { Id = id, UserId = userId, RoleId = roleId };
            using (var connection = ConnectToDB())
            {
                connection.Query(expr, value, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

    }
}

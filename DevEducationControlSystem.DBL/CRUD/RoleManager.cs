using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DevEducationControlSystem.DBL.DTO.Base;
using Dapper;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class RoleManager
    {
        private SqlConnection connection;

        public SqlConnection ConnectToDB()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test; User Id = devEd; Password = qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
        public List<RoleDTO> Select()
        {
            List<RoleDTO> Roles = new List<RoleDTO>();
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

            string sqlExpression = "Role_Select";
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
                            var RoleDTO = new RoleDTO();

                            int id = (int)reader["Id"];
                            string name = (string)reader["Name"];
                            //Roles.Add(new RoleDTO(id, name));
                            Roles.Add(RoleDTO);
                        }
                    }
                }
            }
            finally
            {
                connection.Close();
            }
            return Roles;

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

        public void Add(string name)
        {
            string expr = "[Role_Add]";
            var value = new { Name = name };
            using (var connection = ConnectToDB())
            {
                connection.Query(expr, value, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public void Delete(int id)
        {
            string expr = "[Role_Delete]";
            var value = new { Id = id };
            using (var connection = ConnectToDB())
            {
                connection.Query(expr, value, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public void Update(int id, string name)
        {
            string expr = "[Role_Update]";
            var value = new { Id = id , Name = name };
            using (var connection = ConnectToDB())
            {
                connection.Query(expr, value, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}



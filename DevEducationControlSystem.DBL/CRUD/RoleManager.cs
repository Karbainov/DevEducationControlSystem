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
            //Тут как-то заполняется


            return RoleDTOs;
        }

        public RoleDTO SelectById(int id)
        {
            var RoleDTO = new RoleDTO();
            //Тут как-то заполняется

            connection.Open();

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



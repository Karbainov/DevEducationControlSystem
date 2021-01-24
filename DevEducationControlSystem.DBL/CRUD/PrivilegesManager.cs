using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace DevEducationControlSystem.DBL.CRUD
{
    class PrivilegesManager
    {
        private SqlConnection connection;

        public PrivilegesManager()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test; User Id = devEd; Password = qqq!11";
            connection = new SqlConnection(connectionString);
        }

        public List<PrivilegesDTO> Select()
        {
            var PrivilegesDTOs = new List<PrivilegesDTO>();

            try
            {
                connection.Open();
            }
            finally
            {
                connection.Close();
                throw new Exception("DataBase connection failed");
            }

            string sqlExpression = "EXEC Privileges_Select";
            SqlCommand command = new SqlCommand(sqlExpression, connection);


            try
            {
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            var PrivilegesDTO = new PrivilegesDTO
                            {
                                Id = (int)reader["Id"],
                                Name = (string)reader["Name"]
                            };

                            PrivilegesDTOs.Add(PrivilegesDTO);
                        }
                    }
                }
            }
            finally
            {
                connection.Close();
            }

            return PrivilegesDTOs;

        }

        public PrivilegesDTO SelectById(int id)
        {
            var PrivilegesDTO = new PrivilegesDTO();

            try
            {
                connection.Open();
            }
            finally
            {
                connection.Close();
                throw new Exception("DataBase connection failed");
            }

            string sqlExpression = $"EXEC Privileges_SelectById  {id}";
            SqlCommand command = new SqlCommand(sqlExpression, connection);

            SqlDataReader reader = command.ExecuteReader();

            try
            {
                reader.Read();
                PrivilegesDTO.Id = (int)reader["Id"];
                PrivilegesDTO.Name = (string)reader["Name"];
            }
            finally
            {
                reader.Close();
                connection.Close();
            }

            return PrivilegesDTO;

        }
    }
}

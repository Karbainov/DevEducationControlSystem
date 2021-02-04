using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.DTO.Base;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class User_GroupManager
    {
        private string _connectionString;

        public User_GroupManager()
        {
            _connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test; User Id = devEd; Password = qqq!11";
            
        }
        public void Add(int userId, int groupId)
        {
            string expr = "[User_Group_Add]";
            var value = new { UserId = userId, GroupId = groupId };
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }
        public void Delete(int id)
        {   
            string expr = "[User_Group_Delete]";
            var value = new { Id = id };
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(int id)
        {
            string expr = "[User_Group_Update]";
            var value = new { Id = id };
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }
        public List<User_GroupDTO> Select()
        {
            var User_GroupDTOs = new List<User_GroupDTO>();
            string expr = "[User_Group_Select]";
            using (var connection = new SqlConnection(_connectionString))
            {
                User_GroupDTOs = connection.Query<User_GroupDTO>(expr, commandType: CommandType.StoredProcedure).AsList();
            }

            return User_GroupDTOs;
        }

        public List<User_GroupDTO> SelectByUserId(int userId)
        {
            List<User_GroupDTO> User_GroupDTOs;
            string expr = "[SelectUserGroupByUserId]";
            var value = new { UserId = userId };
            using (var connection = new SqlConnection(_connectionString))
            {
                User_GroupDTOs = connection.Query<User_GroupDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList();
            }

            return User_GroupDTOs;
        }
        public User_GroupDTO SelectById(int id)
        {
            var User_GroupDTO = new User_GroupDTO();
            var connection = new SqlConnection(_connectionString);
            connection.Open();

            string sqlExpression = "EXEC User_Group_SelectById " + id;
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            using SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            User_GroupDTO.Id = (int)reader["Id"];
            User_GroupDTO.UserId = (int)reader["UserId"];
            User_GroupDTO.GroupId = (int)reader["GroupId"];
            
            reader.Close();
            connection.Close();

            return User_GroupDTO;
        }

        public void DeleteUserFromGroupByUserId(int userId)
        {
            string expr = "[DeleteUserFromGroupByUserId]";

            var value = new { UserId = userId };
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }
        public void ReplaceUserToAnotheGroupByUserId(int userId, int groupId)
        {
            string expr = "[ReplaceUserToAnotherGroupByUserId]";

            var value = new { UserId = userId, GroupId = groupId };
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }


    }
}

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
        string _connectionString;
        public User_GroupManager()
        {
            _connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";

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

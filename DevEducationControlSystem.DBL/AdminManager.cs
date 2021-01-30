using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.DBL.CRUD;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace DevEducationControlSystem.DBL
{
    public class AdminManager
    {
        User_GroupManager _user_GroupManager;
        string _connectionString;
        public AdminManager()
        {
            _connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            _user_GroupManager = new User_GroupManager();
        }
        public void AddUserToGroup(int userId, int groupId)
        {
            _user_GroupManager.Add(userId, groupId);
        }
        public void DeleteUserFromGroupByUserId(int userId)
        {
            string expr = "[DeleteUserFromGroupByUserId]";

            var value = new { UserId = userId};
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }
        public void ReplaceUserToAnotheGroup(int userId, int groupId)
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

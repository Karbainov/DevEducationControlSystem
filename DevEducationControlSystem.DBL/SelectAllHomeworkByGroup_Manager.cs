using Dapper;
using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DevEducationControlSystem.DBL
{
    public class SelectAllHomeworkByGroup_Manager
    {
        private string _connectionString;
        private SqlConnection connection;
        private string expr;


        public SqlConnection GetConnection()
        {
            _connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            connection = new SqlConnection(_connectionString);
            return connection;
        }

        public List<SelectAllHomeworkByGroupDTO> Get(int GroupId)
        {
            List<SelectAllHomeworkByGroupDTO> homeworksByGroup = new List<SelectAllHomeworkByGroupDTO>();
            var value = new { GroupId = GroupId };
            expr = "[SelectAllHomeworkByGroup]";

            using (connection = GetConnection())
            {
                homeworksByGroup = connection.Query<SelectAllHomeworkByGroupDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<SelectAllHomeworkByGroupDTO>();
            }
            return homeworksByGroup;
        }
    }
}

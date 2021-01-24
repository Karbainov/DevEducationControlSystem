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
        private string expr;


        public SelectAllHomeworkByGroup_Manager()
        {
            _connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            expr = "[SelectAllHomeworkByGroup]";
        }


        public List<SelectAllHomeworkByGroupDTO> Get(int GroupId)
        {
            List<SelectAllHomeworkByGroupDTO> homeworksByGroup = new List<SelectAllHomeworkByGroupDTO>();
            var value = new { GroupId = GroupId };
            using (var connection = new SqlConnection(_connectionString))
            {
                homeworksByGroup = connection.Query<SelectAllHomeworkByGroupDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<SelectAllHomeworkByGroupDTO>();
            }
            return homeworksByGroup;
        }
    }
}

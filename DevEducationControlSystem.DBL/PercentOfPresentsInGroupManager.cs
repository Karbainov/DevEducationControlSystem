﻿using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;
using System.Data.SqlClient;

namespace DevEducationControlSystem.DBL
{
    public class PercentOfPresentsInGroupManager
    {
        public SqlConnection ConnectToDB()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
        public List<UserPercentOfPresentsDTO> SelectById(int id)
        {
            List<UserPercentOfPresentsDTO> usersPercents = new List<UserPercentOfPresentsDTO>();

            string expr = "[SelectPercentOfPresentsByGroupId]";
            var value = new { GroupId = id };

            using (var connection = ConnectToDB())
            {
                usersPercents = connection.Query<UserPercentOfPresentsDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<UserPercentOfPresentsDTO>();
            }

            return usersPercents;
        }
    }
}

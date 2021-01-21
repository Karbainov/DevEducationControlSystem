﻿using System;
using System.Collections.Generic;
using DevEducationControlSystem.DBL.DTO;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace DevEducationControlSystem.DBL
{
    public class AllGroupMaterialsByTagAndUserId_Manager
    {
        
        string connectionString;
        string expr;

        public AllGroupMaterialsByTagAndUserId_Manager()
        {
            connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            expr = "[GetAllGroupMaterialsByTagAndUserId]";
            
        }

        public List<AllGroupMaterialsByTagAndUserIdDTO> Get(int userId, string tagName)
        {
            List<AllGroupMaterialsByTagAndUserIdDTO> materialsByTag = new List<AllGroupMaterialsByTagAndUserIdDTO>();
            var value = new { UserId = userId, TagName = tagName };
            using (var connection = new SqlConnection(connectionString))
            {
                materialsByTag = connection.Query<AllGroupMaterialsByTagAndUserIdDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<AllGroupMaterialsByTagAndUserIdDTO>();
                //materialsByTag.ForEach(r => Console.WriteLine(r.DuckType + " " + r.ID));
            }
            return materialsByTag;
        }
    }
}
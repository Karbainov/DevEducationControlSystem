using System;
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

        public List<Course_MaterialDTO> Get(int userId, string tagName)
        {
            List<Course_MaterialDTO> materialsByTag = new List<Course_MaterialDTO>();
            var value = new { UserId = userId, TagName = tagName };
            using (var connection = new SqlConnection(connectionString))
            {
                materialsByTag = connection.Query<Course_MaterialDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<Course_MaterialDTO>();
                //materialsByTag.ForEach(r => Console.WriteLine(r.DuckType + " " + r.ID));
            }
            return materialsByTag;
        }
    }
}

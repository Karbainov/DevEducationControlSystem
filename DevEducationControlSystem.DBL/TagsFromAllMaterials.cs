using System;
using System.Collections.Generic;
using DevEducationControlSystem.DBL.DTO;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace DevEducationControlSystem.DBL
{
    public class TagsFromAllMaterials
    {
        
        string connectionString;
        string expr;

        public TagsFromAllMaterials()
        {
            connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            expr = "[SearchByTagsFromAllMaterials]";
            
        }

        public List<TagsFromAllMaterialsDTO> Search(int userId, string tagName)
        {
            List<TagsFromAllMaterialsDTO> materialsByTag = new List<TagsFromAllMaterialsDTO>();
            var value = new { GroupId = userId, TagName = tagName };
            using (var connection = new SqlConnection(connectionString))
            {
                materialsByTag = connection.Query<TagsFromAllMaterialsDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<TagsFromAllMaterialsDTO>();
                //materialsByTag.ForEach(r => Console.WriteLine(r.DuckType + " " + r.ID));
            }
            return materialsByTag;
        }
    }
}

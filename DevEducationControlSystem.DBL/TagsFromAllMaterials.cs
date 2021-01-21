using System;
using System.Collections.Generic;
using DevEducationControlSystem.DBL.DTO;
using System.Text;

namespace DevEducationControlSystem.DBL
{
    class TagsFromAllMaterials
    {
        List<TagsFromAllMaterialsDTO> materialsByTag;

        public TagsFromAllMaterials()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            string expr = "[selectById]";
            var value = new { Id = 1 };
        }

        public TagsFromAllMaterialsDTO Search(int userId, string tagName)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                materialsByTag = connection.Query<TagsFromAllMaterialsDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<DuckTypeDTO>();
                materialsByTag.ForEach(r => Console.WriteLine(r.DuckType + " " + r.ID));
            }
            return materialsByTag;
        }
    }
}

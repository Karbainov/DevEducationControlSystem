using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DevEducationControlSystem.DBL.DTO.Base;
using System.Data;
using Dapper;
using System.Linq;
namespace DevEducationControlSystem.DBL.CRUD
{
    class Theme_TagManager
    {

        public SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        public List<Theme_TagDTO> Select()
        {
            var ThemeTag = new List<Theme_TagDTO>();
            string sqlExpression = "[Theme_Tag_Select]";

            using (var connection = GetConnection())
            {
                ThemeTag = connection.Query<Theme_TagDTO>(sqlExpression, commandType: CommandType.StoredProcedure).ToList<Theme_TagDTO>();
            }
            return ThemeTag;
        }

        public Theme_TagDTO SelectById(int id)
        {
            Theme_TagDTO TehemeTag = new Theme_TagDTO();
            string sqlExpression = "[Theme_Tag_SelectById]";
            var value = new { Id = id };

            using (var connection = GetConnection())
            {
                var themeTags = connection.Query<Theme_TagDTO>(sqlExpression, value, commandType: CommandType.StoredProcedure).AsList<Theme_TagDTO>();
                if (themeTags.Count > 0)
                {
                    TehemeTag = themeTags[0];
                }
            }
            return TehemeTag;
        }

        public void Add(int themeId, int tagId)
        {
            string sqlExpression = "[Theme_Tag_Add]";
            var value = new { ThemeId = themeId, TagId = tagId };

            using (var connection = GetConnection())
            {
                connection.Query(sqlExpression, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int id)
        {
            string sqlExpression = "[Theme_Tag_Delete]";
            var value = new { Id = id };

            using (var connection = GetConnection())
            {
                connection.Query(sqlExpression, value, commandType: CommandType.StoredProcedure);
            }
        }
        public void Update(int id, int themeId, int tagId)
        {
            string sqlExpression = "[Theme_Tag_Update]";
            var value = new { Id = id, ThemeId = themeId, TagId = tagId};

            using (var connection = GetConnection())
            {
                connection.Query(sqlExpression, value, commandType: CommandType.StoredProcedure);
            }
        }        
    }
}

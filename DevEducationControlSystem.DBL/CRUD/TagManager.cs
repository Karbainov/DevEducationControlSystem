using Dapper;
using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class TagManager
    {
        public SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        public List<AllTagsOnCourseDTO> SelectAllTagsOnCourse(int id)
        {
            var themesList = new List<AllTagsOnCourseDTO>();
            string expr = "[SelectAllTagsOnCourse]";
            var value = new { id };

            using (var connection = GetConnection())
            {
                themesList = connection.Query<AllTagsOnCourseDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList();
            }

            return themesList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using DevEducationControlSystem.DBL.DTO.Base;
using DevEducationControlSystem.DBL.DTO;

namespace DevEducationControlSystem.DBL.CRUD
{
   public class AllInfoUserOnTheCourseManager
    {
        public AllInfoUserOnTheCourseDTO AllInfoUserOnTheCourseById(int courseId)
        {
            string sqlExpression = "[AllInfoUserOnTheCourse]";
            var value = new { courseId };
            using (var connection = SqlServerConnection.GetConnection())
            {
                return connection.QuerySingle<AllInfoUserOnTheCourseDTO>(sqlExpression, value, commandType: CommandType.StoredProcedure);
            }
        }
    }
}

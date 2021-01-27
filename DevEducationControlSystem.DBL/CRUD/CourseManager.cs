using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.DBL.DTO.Base;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class CourseManager
    {
        public CourseDTO SelectById(int id)
        {
            CourseDTO courseDTO = new CourseDTO();
            string expression = "[Course_SelectById]";
            var parameter = new { Id=id };
            using (var connection = SqlServerConnection.GetConnection())
            {
                courseDTO = connection.QuerySingle<CourseDTO>(expression, parameter, commandType: CommandType.StoredProcedure);
            }
            return courseDTO;
        }
    }
}

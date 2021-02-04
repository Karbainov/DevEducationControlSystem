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
    public class NumberOfStudentsOnTheCourseManager
    {        
        public List <NumberOfStudentsOnTheCourseDTO> SelectCourseInfoById (int courseId)
        {
            string sqlExpression = "[GetAllInformationAboutUserOnCourseById]";
            var value = new { courseId };
            using (var connection = SqlServerConnection.GetConnection())
            {
                return connection.Query<NumberOfStudentsOnTheCourseDTO>(sqlExpression, value, commandType: CommandType.StoredProcedure).AsList<NumberOfStudentsOnTheCourseDTO>();
            }
        }     


    }
}

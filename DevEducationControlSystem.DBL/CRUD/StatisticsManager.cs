using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.DBL.DTO;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace DevEducationControlSystem.DBL.CRUD
{
    class StatisticsManager
    {
        private string _connectionString;

        public StatisticsManager()
        {
            _connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
        }

        List<CountsStudentsTeachersTutorsByGroupDTO> CountsStudentsTeachersTutorsByGroupDTO()
        {
            List<CountsStudentsTeachersTutorsByGroupDTO> CountRole = null;
            string expression = "[CountsStudentsTeachersTutorsByGroupDTO]";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                CountRole = connection.Query<CountsStudentsTeachersTutorsByGroupDTO>(expression, commandType: CommandType.StoredProcedure).AsList<CountsStudentsTeachersTutorsByGroupDTO>();
            }
                return CountRole;
        }
    }
}

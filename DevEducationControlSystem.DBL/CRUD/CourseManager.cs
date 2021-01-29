using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.DBL.DTO.Base;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class CourseManager
    {
        public void Add(string name, string description, int durationInWeeks)
        {
            string expression = "[Course_Add]";
            var parameter = new
            {
                Name = name,
                Description = description,
                DurationInWeeks = durationInWeeks
            };
            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query(expression, parameter, commandType: CommandType.StoredProcedure);
            }
        }
        public List<CourseDTO> Select()
        {
            var courseDTOs = new List<CourseDTO>();
            string expression = "[Course_Select]";
            using (var connection = SqlServerConnection.GetConnection())
            {
                courseDTOs = connection.Query<CourseDTO>(expression, commandType: CommandType.StoredProcedure).ToList<CourseDTO>();
            }
            return courseDTOs;
        }
        public CourseDTO SelectById(int id)
        {
            var courseDTO = new CourseDTO();
            string expression = "[Course_SelectById]";
            var parameter = new { Id = id };
            using (var connection = SqlServerConnection.GetConnection())
            {
                courseDTO = connection.QuerySingle<CourseDTO>(expression, parameter, commandType: CommandType.StoredProcedure);
            }
            return courseDTO;
        }
        public void Update(int id, string name, string description, int durationInWeeks, bool isDeleted)
        {
            string expression = "[Course_Update]";
            var parameter = new
            {
                Id = id,
                Name = name,
                Description = description,
                DurationInWeeks = durationInWeeks,
                IsDeleted = isDeleted
            };
            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query(expression, parameter, commandType: CommandType.StoredProcedure);
            }
        }
        public void Delete(int id)
        {
            string expression = "[Course_Delete]";
            var parameter = new  { Id = id };
            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query(expression, parameter, commandType: CommandType.StoredProcedure);
            }
        }
    }
}

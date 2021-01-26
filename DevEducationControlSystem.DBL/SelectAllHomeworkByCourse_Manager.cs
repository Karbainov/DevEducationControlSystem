using Dapper;
using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using DevEducationControlSystem.DBL.DTO.Base;

namespace DevEducationControlSystem.DBL
{
    public class SelectAllHomeworkByCourse_Manager
    {
        private SqlConnection _connection;
        private string expr;


        public SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            _connection = new SqlConnection(connectionString);
            return _connection;
        }


        public Dictionary<int, SelectAllHomeworkByCourseDTO> Get(int CourseId)
        {
            Dictionary<int, SelectAllHomeworkByCourseDTO> homeworksByCourse = new Dictionary<int, SelectAllHomeworkByCourseDTO>();
            var value = new { CourseId };
            expr = "[SelectAllHomeworkByCourse]";

            using (_connection = GetConnection())
            {
                var item = _connection.Query<SelectAllHomeworkByCourseDTO, ResourceDTO, SelectAllHomeworkByCourseDTO>(expr, 
                    (Homework, Resource) => 
                    {
                        SelectAllHomeworkByCourseDTO homeworkCourse = new SelectAllHomeworkByCourseDTO();

                        if (homeworksByCourse.TryGetValue(homeworkCourse.HomeworkId, out homeworkCourse))
                        {
                            homeworkCourse = Homework;
                            homeworksByCourse.Add(homeworkCourse.HomeworkId, homeworkCourse);
                        }

                        if(homeworkCourse.Resource == null)
                        {
                            homeworkCourse.Resource = new List<ResourceDTO>();
                        }
                        homeworkCourse.Resource.Add(Resource);

                        return homeworkCourse;

                    }, commandType: CommandType.StoredProcedure, splitOn : "Resource").AsList<SelectAllHomeworkByCourseDTO>();
            }

            return homeworksByCourse;
        }
    }
}

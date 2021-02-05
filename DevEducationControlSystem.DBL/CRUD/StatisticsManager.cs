using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.DBL.DTO;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class StatisticsManager
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


        public List<NumberOfUsersWithStatusInCourseInCityDTO> SelectNumberOfUsersWithStatusInCourseInCity()
        {
            List<NumberOfUsersWithStatusInCourseInCityDTO> CountUser = new List<NumberOfUsersWithStatusInCourseInCityDTO>();
            string expr = "[SelectNumberOfUsersWithStatusInCourseInCity]";
            using (var connection = SqlServerConnection.GetConnection())
            {
                List<NumberOfUsersWithStatusInCourseInCityDTO> cities = new List<NumberOfUsersWithStatusInCourseInCityDTO>();
                CountUser = connection.Query<NumberOfUsersWithStatusInCourseInCityDTO, 
                    NumberOfUsersByStatusInCourseDTO, 
                    NumberOfUsersByStatusDTO, 
                    NumberOfUsersWithStatusInCourseInCityDTO>(expr, 
                    (city, course, status) => 
                    {
                        NumberOfUsersWithStatusInCourseInCityDTO tmpCity = null;

                        foreach(var r in cities)
                        {
                            if(r.CityId==city.CityId)
                            {
                                tmpCity = r;
                                break;
                            }
                        }
                        if (tmpCity == null)
                        {
                            tmpCity = city;
                            tmpCity.NumberOfUsersByStatusInCourse = new List<NumberOfUsersByStatusInCourseDTO>();
                            cities.Add(tmpCity);
                        }


                        NumberOfUsersByStatusInCourseDTO tmpCourse = null;

                        foreach (var r in tmpCity.NumberOfUsersByStatusInCourse)
                        {
                            if (r.CourseId == course.CourseId)
                            {
                                tmpCourse = r;
                                break;
                            }
                        }
                        if (tmpCourse == null)
                        {
                            tmpCourse = course;
                            tmpCourse.NumberOfUsersByStatus = new List<NumberOfUsersByStatusDTO>();
                            tmpCity.NumberOfUsersByStatusInCourse.Add(tmpCourse);
                        }

                        tmpCourse.NumberOfUsersByStatus.Add(status);

                        return tmpCity;
                    },
                    splitOn: "CourseId, StatusId", 
                    commandType: CommandType.StoredProcedure).AsList<NumberOfUsersWithStatusInCourseInCityDTO>();
            }
            return CountUser;
        }

        List<CountStudentsOnCourseByGroupsDTO> CountStudentsOnCourseByGroupsDTO()
        {
            List<CountStudentsOnCourseByGroupsDTO> Count = null;
            string expression = "[CountStudentsOnCourseByGroupsDTO]";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                Count = connection.Query<CountStudentsOnCourseByGroupsDTO>(expression, commandType: CommandType.StoredProcedure).AsList<CountStudentsOnCourseByGroupsDTO>();
            }
            return Count;
        }
    }
}

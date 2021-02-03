﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;
using DevEducationControlSystem.DBL.DTO;

namespace DevEducationControlSystem.DBL
{
    public class StatisticManager
    {
        string _connectionString;
        public StatisticManager()
        {
            _connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
        }
        public SqlConnection ConnectToDB()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            return connection;
        }
        public List<UserPercentOfPresentsDTO> SelectPercentOfPresentsByGroupId(int groupId)
        {
            List<UserPercentOfPresentsDTO> usersPercents = new List<UserPercentOfPresentsDTO>();

            string expr = "[SelectPercentOfPresentsByGroupId]";
            var value = new { GroupId = groupId };

            using (var connection = ConnectToDB())
            {
                usersPercents = connection.Query<UserPercentOfPresentsDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<UserPercentOfPresentsDTO>();
            }

            return usersPercents;
        }

        public List<CountsStudentsTeachersTutorsByGroupDTO> CountsStudentsTeachersTutorsByGroupDTO()
        {
            List<CountsStudentsTeachersTutorsByGroupDTO> CountRole = null;
            string expression = "[CountsStudentsTeachersTutorsByGroupDTO]";
            using (var connection = ConnectToDB())
            {
                CountRole = connection.Query<CountsStudentsTeachersTutorsByGroupDTO>(expression, commandType: CommandType.StoredProcedure).AsList<CountsStudentsTeachersTutorsByGroupDTO>();
            }
            return CountRole;
        }

        public int SelectNumberOfStudentsByTeacherId(int id)
        {
            int number = 0;
            string expr = "[SelectNumberOfStudentsByTeacherId]";
            var value = new { UserId = id };

            using (var connection = ConnectToDB())
            {
                var numbers = connection.Query<int>(expr, value, commandType: CommandType.StoredProcedure).AsList<int>();
                if (numbers.Count > 0)
                {
                    number = numbers[0];
                }
            }

            return number;
        }

        public List<NumberOfStudentsInGroupDTO> SelectNumberOfStudentsInGroupsByTeacherId(int id)
        {
            var DTOs = new List<NumberOfStudentsInGroupDTO>();
            string expr = "[SelectNumberOfStudentsInGroupsByTeacherId]";
            var value = new { UserId = id };

            using (var connection = ConnectToDB())
            {
                DTOs = connection.Query<NumberOfStudentsInGroupDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<NumberOfStudentsInGroupDTO>();
            }

            return DTOs;
        }

        public List<NumberOfTeachersByCourseDTO> SelectNumberOfTeachersByCourse()
        {
            var teachersByCourseList = new List<NumberOfTeachersByCourseDTO>();
            string expr = "[SelectNumberOfTeachersByCourse]";
            using (var connection = SqlServerConnection.GetConnection())
            {
                teachersByCourseList = connection.Query<NumberOfTeachersByCourseDTO>(expr, commandType: CommandType.StoredProcedure).AsList();
            }

            return teachersByCourseList;
        }

        public List<SelectAllGroupsAndAmountPeopleInGroupByCityDTO> SelectAllGroupsAndAmountPeopleInGroupByCity()
        {
            var allGroupssAndAmountPeopleInGroupByCity = new List<SelectAllGroupsAndAmountPeopleInGroupByCityDTO>();
            string expression = "[SelectAllGroupsAndAmountPeopleInGroupByCityDTO]";
            using (var connection = SqlServerConnection.GetConnection())
            {
                allGroupssAndAmountPeopleInGroupByCity = connection.Query<SelectAllGroupsAndAmountPeopleInGroupByCityDTO>(expression, commandType: CommandType.StoredProcedure).AsList();
            }

            return allGroupssAndAmountPeopleInGroupByCity;
        }

        public List<StudentsStudyingAfterBaseDTO> SelectStudentsStudyingAfterBase()
        {
            var cityList = new List<StudentsStudyingAfterBaseDTO>();
            string expression = "[SelectStudentsStudyingAfterBase]";
            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query<StudentsStudyingAfterBaseDTO, UsersInGroupCountDTO, StudentsStudyingAfterBaseDTO>(expression,  (City,Group)=>
                {
                    StudentsStudyingAfterBaseDTO city = null;

                    foreach (var c in cityList)
                    {
                        if (City.Cityname == c.Cityname)
                        {
                            city = c;
                            break;
                        }

                    }

                    if (city == null)
                    {
                        city = City;
                        cityList.Add(city);
                    }
                    if (city.groupList == null) city.groupList = new List<UsersInGroupCountDTO>();


                    city.groupList.Add(Group);
                    return city;
                },

                  commandType: CommandType.StoredProcedure,splitOn: "Groupname");
            }

            return cityList;
            
        }

        public List<CountStudentsOnCourseByGroupsDTO> GetCountStudentsOnCourseByGroups(int id)
        {
            List<CountStudentsOnCourseByGroupsDTO> NumberOfStudents = null;
            string expression = "[CountStudentsOnCourseByGroups]";
            var value = new { CourseId = id };

            using (var connection = ConnectToDB())
            {
                NumberOfStudents = connection.Query<CountStudentsOnCourseByGroupsDTO>(expression, value, commandType: CommandType.StoredProcedure).AsList();
            }
            return NumberOfStudents;
        }

    }

    }


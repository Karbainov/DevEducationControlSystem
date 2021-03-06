﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;
using DevEducationControlSystem.DBL.DTO.StatisticsForMethodist;
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

        public List<SelectAmountOfGroupsStudentsGradStudentsRateForTeachersDTO> SelectGroupsStudentsRateForTeacher()
        {
            var teachersByCourseList = new List<SelectAmountOfGroupsStudentsGradStudentsRateForTeachersDTO>();
            string expr = "[SelectAmountOfGroupsStudentsGradStudentsRateForTeachers]";
            using (var connection = SqlServerConnection.GetConnection())
            {
                teachersByCourseList = connection.Query<SelectAmountOfGroupsStudentsGradStudentsRateForTeachersDTO>(expr, commandType: CommandType.StoredProcedure).AsList();
            }

            return teachersByCourseList;
        }

        public NumberOfTeachersByCourseIdDTO SelectNumberOfTeachersByCourseId(int id)
        {
            var teachersByCourse = new NumberOfTeachersByCourseIdDTO();
            string expr = "[SelectNumberOfTeachersByCourseId]";
            var value = new { id };
            using (var connection = SqlServerConnection.GetConnection())
            {
                teachersByCourse = connection.QuerySingle<NumberOfTeachersByCourseIdDTO>(expr, value, commandType: CommandType.StoredProcedure);
            }

            return teachersByCourse;
        }

        public List<TeacherOnCourseDTO> SelectTeachersOnCourseStatisctic()
        {
            var teachersByCourseList = new List<TeacherOnCourseDTO>();
            string expr = "[GetTeachersStatistic]";
            using (var connection = SqlServerConnection.GetConnection())
            {
                teachersByCourseList = connection.Query<TeacherOnCourseDTO>(expr, commandType: CommandType.StoredProcedure).AsList();
            }

            return teachersByCourseList;
        }

        public List<NumberOfUsersWithStatusInCourseInCityDTO> SelectNumberOfUsersWithStatusInCourseInCity()
        {
            string expr = "[SelectNumberOfUsersWithStatusInCourseInCity]";
            using (var connection = SqlServerConnection.GetConnection())
            {
                List<NumberOfUsersWithStatusInCourseInCityDTO> cities = new List<NumberOfUsersWithStatusInCourseInCityDTO>();
                connection.Query<NumberOfUsersWithStatusInCourseInCityDTO,
                    NumberOfUsersByStatusInCourseDTO,
                    NumberOfUsersByStatusDTO,
                    NumberOfUsersWithStatusInCourseInCityDTO>(expr,
                    (city, course, status) =>
                    {
                        NumberOfUsersWithStatusInCourseInCityDTO tmpCity = null;

                        foreach (var r in cities)
                        {
                            if (r.CityId == city.CityId)
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
                return cities;
            }

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

        public List<StudentsStudyingAfterBaseDTO> StudentsStudyingAfterBase()
        {
            var cityList = new List<StudentsStudyingAfterBaseDTO>();
            string expression = "[SelectStudentsStudyingAfterBase]";
            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query<StudentsStudyingAfterBaseDTO, CorsesinCityDTO, GroupkandStatusInCourseDTO,
            StudentsStudyingAfterBaseDTO>(expression, (City, Course, Group) =>
               {
                   StudentsStudyingAfterBaseDTO city = null;
                   CorsesinCityDTO course = null;
                   GroupkandStatusInCourseDTO group = null;

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

                   if (city.CorsesinCity == null)
                   {
                       city.CorsesinCity = new List<CorsesinCityDTO>();
                   }

                   foreach (var c in city.CorsesinCity)
                   {
                       if (c.CourseName == Course.CourseName)
                       {
                           course = c;
                       }
                   }

                   if (course == null)
                   {
                       course = Course;
                       city.CorsesinCity.Add(course);
                   }

                   if (course.GroupkandStatusInCourse == null)
                   {
                       course.GroupkandStatusInCourse = new List<GroupkandStatusInCourseDTO>();
                   }
                   foreach (var g in course.GroupkandStatusInCourse)
                   {
                       group = g;
                   }

                   if (group == null)
                   {
                       group = Group;
                       course.GroupkandStatusInCourse.Add(group);
                   }
                   return null;
               },

                    commandType: CommandType.StoredProcedure, splitOn: "CourseName, GroupName");
                return cityList;

            }
        }

           public List<CountHomeworkByThemeInCityCourseGroupDTO> CountHomeworkByThemeInCityCourseGroup()
                {
                    var statisticList = new List<CountHomeworkByThemeInCityCourseGroupDTO>();
                    string expression = "[SelectCityCourseHomeworkThemeStatus]";
                    using (var connection = SqlServerConnection.GetConnection())
                        connection.Query<CountHomeworkByThemeInCityCourseGroupDTO, GroupInCourseDTO, ThemeInGroupDTO, CountOfHomeworkByThemeDTO,
                        CountHomeworkByThemeInCityCourseGroupDTO>(expression, (City, Course, Group, Homework) =>
                        {
                            CountHomeworkByThemeInCityCourseGroupDTO city = null;
                            GroupInCourseDTO course = null;
                            ThemeInGroupDTO group = null;
                            CountOfHomeworkByThemeDTO homework = null;

                            foreach (var s in statisticList)
                            {
                                if (s.CityName == City.CityName)
                                {
                                    city = s;
                                }
                            }

                            if (city == null)
                            {
                                city = City;
                                statisticList.Add(city);
                            }

                            if (city.GroupInCourse == null)
                            {
                                city.GroupInCourse = new List<GroupInCourseDTO>();
                            }

                            foreach (var c in city.GroupInCourse)
                            {
                                if (c.CourseName == Course.CourseName)
                                {
                                    course = c;
                                }
                            }

                            if (course == null)
                            {
                                course = Course;
                                city.GroupInCourse.Add(course);
                            }

                            if (course.ThemeInGroup == null)
                            {
                                course.ThemeInGroup = new List<ThemeInGroupDTO>();
                            }

                            foreach (var g in course.ThemeInGroup)
                            {
                                group = g;
                            }

                            if (group == null)
                            {
                                group = Group;
                                course.ThemeInGroup.Add(group);
                            }

                            if (group.CountOfHomeworkByTheme == null)
                            {
                                group.CountOfHomeworkByTheme = new List<CountOfHomeworkByThemeDTO>();
                            }

                            group.CountOfHomeworkByTheme.Add(Homework);

                            return null;

                        },

                    commandType: CommandType.StoredProcedure, splitOn: "CourseName, GroupName,ThemeName");
                    return statisticList;

                }


                public List<CountStudentsOnCourseByGroupsDTO> GetCountStudentsOnCourseByGroups(int id)
                {
                    var NumberOfStudentsList = new List<CountStudentsOnCourseByGroupsDTO>();
                    string expression = "[CountStudentsOnCourseByGroups]";
                    var value = new { CourseId = id };

                    using (var connection = SqlServerConnection.GetConnection())
                    {
                        NumberOfStudentsList = connection.Query<CountStudentsOnCourseByGroupsDTO>(expression, value, commandType: CommandType.StoredProcedure).AsList();
                    }
                    return NumberOfStudentsList;
                }


            }
        }
    


    
    


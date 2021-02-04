using System;
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

        public List<StudentsStudyingAfterBaseDTO> SelectStudentsStudyingAfterBase()
        {
            var cityList = new List<StudentsStudyingAfterBaseDTO>();
            string expression = "[SelectStudentsStudyingAfterBase]";
            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query<StudentsStudyingAfterBaseDTO, UsersInGroupCountDTO, StudentsStudyingAfterBaseDTO>(expression, (City, Group) =>
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

                  commandType: CommandType.StoredProcedure, splitOn: "Groupname");
            }

            return cityList;

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

                    foreach (var S in statisticList)
                    {
                        if (S.CityName == City.CityName)
                        {
                            city = S;
                            break;
                        }
                    }

                    if (city == null)
                    {
                        city = City;
                        city.GroupInCourse = new List<GroupInCourseDTO>();
                        statisticList.Add(city);
                    }

                    GroupInCourseDTO course = null;

                    foreach (var C in city.GroupInCourse)
                    {
                        if (C.CourseName == Course.CourseName)
                        {
                            course = C;
                            break;
                        }
                    }

                    if (course == null)
                    {
                        course = Course;
                        course.ThemeInGroup = new List<ThemeInGroupDTO>();
                        city.GroupInCourse.Add(course);
                    }

                    ThemeInGroupDTO group = null;

                    foreach (var G in course.ThemeInGroup)
                    {
                        if (G.GroupName == Group.GroupName)
                        {
                            group = G;
                            break;
                        }
                    }

                    if (group == null)
                    {
                        group = Group;
                        group.CountOfHomeworkByTheme = new List<CountOfHomeworkByThemeDTO>();
                        course.ThemeInGroup.Add(group);
                    }

                    CountOfHomeworkByThemeDTO homework = null;

                    foreach (var H in group.CountOfHomeworkByTheme)
                    {
                        if (H.HomeworkName == Homework.HomeworkName)
                        {
                            homework = H;
                            break;
                        }
                    }

                    return city;
                },

            commandType: CommandType.StoredProcedure, splitOn: "CourseName, GroupName,ThemeName");
            return statisticList;
        }
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


    
    


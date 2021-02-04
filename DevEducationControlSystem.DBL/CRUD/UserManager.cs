using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;
using DevEducationControlSystem.DBL.DTO.Base;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class UserManager
    {

        public List<CourseDurationOfCurrentStudentDTO> GetCourseDurationOfCurrentStudentById(int id)
        {
            var CourseDurationOfCurrentStudent = new List<CourseDurationOfCurrentStudentDTO>();
            string expr = "[GetCourseDurationOfCurrentStudentById]";
            var value = new { id };

            using (var connection = SqlServerConnection.GetConnection())
            {
                CourseDurationOfCurrentStudent = connection.Query<CourseDurationOfCurrentStudentDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<CourseDurationOfCurrentStudentDTO>(); ;
            }
            return CourseDurationOfCurrentStudent;
        }

        public List<CourseOfCurrentUserDTO> GetAllCoursesOfCurrentUserById(int id)
        {
            var AllCoursesOfCurrentUser = new List<CourseOfCurrentUserDTO>();
            string expr = "[GetAllCoursesOfCurrentUserById]";
            var value = new { id };

            using (var connection = SqlServerConnection.GetConnection())
            {
                AllCoursesOfCurrentUser = connection.Query<CourseOfCurrentUserDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<CourseOfCurrentUserDTO>(); ;
            }
            return AllCoursesOfCurrentUser;
        }

        public List<UserOfCurrentCourseDTO> GetAllUsersOfCurrentCourseById(int id)
        {
            var usersOfCurrentCourse = new List<UserOfCurrentCourseDTO>();
            string expr = "[GetAllUsersOfCurrentCourseById]";
            var value = new { id };

            using (var connection = SqlServerConnection.GetConnection())
            {
                usersOfCurrentCourse = connection.Query<UserOfCurrentCourseDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<UserOfCurrentCourseDTO>(); ;
            }
            return usersOfCurrentCourse;
        }
        public List<LessonAndFeedbackDTO> SelectLessonsAndFeedbackByUserId(int id)
        {
            var lessonsAndFeedbacks = new List<LessonAndFeedbackDTO>();
            string expr = "[SelectLessonsAndFeedbackByUserId]";
            var value = new { id };

            using (var connection = SqlServerConnection.GetConnection())
            {
                lessonsAndFeedbacks = connection.Query<LessonAndFeedbackDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<LessonAndFeedbackDTO>(); ;
            }
            return lessonsAndFeedbacks;
        }

        public List<UserWithRoleDTO> SelectUsersByGroupId (int groupId)
        {
            string expr = "[SelectUsersByGroupId]";
            var value = new {groupId};

            List<UserWithRoleDTO> users = new List<UserWithRoleDTO>();
            
            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query<UserWithRoleDTO, RoleDTO, UserWithRoleDTO>(expr,
                (user, role) =>
                {
                    UserWithRoleDTO tmpUserWithRole = null;
                    foreach (var r in users)
                    {
                        if (r.UserId == user.UserId)
                        {
                            tmpUserWithRole = r;
                            break;
                        }
                    }
                    if (tmpUserWithRole == null)
                    {
                        tmpUserWithRole = user;
                        users.Add(tmpUserWithRole);
                    }
                    if(tmpUserWithRole.Roles == null)
                    {
                        tmpUserWithRole.Roles = new List<RoleDTO>();
                    }

                    tmpUserWithRole.Roles.Add(role);
                    return tmpUserWithRole;
                },
                value,
                splitOn: "Id",
                commandType: CommandType.StoredProcedure);
            }
            return users;
        }

        public List<LoginPassRoleDTO> GetLoginPassRole(string login)
        {
            string expr = "GetLoginPassRole";
            var listUserAuthtorisInfo = new List<LoginPassRoleDTO>();
            var value = new { login };
            using(var connection = SqlServerConnection.GetConnection())
            {
                connection.Query<LoginPassRoleDTO, RoleDTO, LoginPassRoleDTO>(expr,
                (user, role) =>
                {
                    LoginPassRoleDTO tmpLoginPassRole = null;

                    foreach (var r in listUserAuthtorisInfo)
                    {
                        if (r.UserId == user.UserId)
                        {
                            tmpLoginPassRole = r;
                            break;
                        }
                    }
                    if (tmpLoginPassRole == null)
                    {
                        tmpLoginPassRole = user;
                        listUserAuthtorisInfo.Add(tmpLoginPassRole);
                    }
                    if (tmpLoginPassRole.Roles == null)
                    {
                        tmpLoginPassRole.Roles = new List<RoleDTO>();
                    }
                    tmpLoginPassRole.Roles.Add(role);
                    return tmpLoginPassRole;
                },
                value,
                commandType: CommandType.StoredProcedure, splitOn: "Id");
            }
            return listUserAuthtorisInfo;
        }

        public void Add()

        {

            using (var connection = SqlServerConnection.GetConnection())
            {

                connection.Query<UserDTO>("[User_Add]", commandType: CommandType.StoredProcedure);

            }

        }



        public void Delete()

        {

            using (var connection = SqlServerConnection.GetConnection())
            {

                connection.Query<UserDTO>("[User_Delete]", commandType: CommandType.StoredProcedure);

            }

        }



        public void Update()

        {

            using (var connection = SqlServerConnection.GetConnection())
            {

                connection.Query<UserDTO>("[User_Update]", commandType: CommandType.StoredProcedure);

            }

        }



        public List<UserDTO> Select()
        {

            using (var connection = SqlServerConnection.GetConnection())
            {

                var UsersDTO = connection.Query<UserDTO>("[User_Select]", commandType: CommandType.StoredProcedure).AsList<UserDTO>();

                return UsersDTO;

            }
        }

        public UserDTO SelectById(int id)
        {
            using (var connection = SqlServerConnection.GetConnection())

            {

                var UserDTO = connection.QuerySingle<UserDTO>("[User_SelectById]", id, commandType: CommandType.StoredProcedure);
                return UserDTO;

            }
        }
    }
}

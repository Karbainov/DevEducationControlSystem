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
                        if (r.Id == user.Id)
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
                splitOn: "RoleId",
                commandType: CommandType.StoredProcedure);
            }
            return users;
        }

        public List<AllInfoOfUserDTO> GetInfoOfAllUsers()
        {
            string expr = "[GetInfoOfAllUsers]";

            List<AllInfoOfUserDTO> users = new List<AllInfoOfUserDTO>();



            using (var connection = SqlServerConnection.GetConnection())
            {

                connection.Query<AllInfoOfUserDTO, RoleInfoForUserDTO, CourseInfoForUserDTO, GroupInfoForUserDTO, AllInfoOfUserDTO>(expr,
                (user, role, course, group) =>
                {
                    AllInfoOfUserDTO tmpAllInfoOfUserDTO = null;

                    foreach (var r in users)
                    {
                        if (r.Id == user.Id)
                        {
                            tmpAllInfoOfUserDTO = r;
                            break;
                        }
                    }
                    if (tmpAllInfoOfUserDTO == null)
                    {
                        tmpAllInfoOfUserDTO = user;
                        users.Add(tmpAllInfoOfUserDTO);
                    }
                    if (tmpAllInfoOfUserDTO.Roles == null)
                    {
                        tmpAllInfoOfUserDTO.Roles = new List<RoleInfoForUserDTO>();
                    }

                    tmpAllInfoOfUserDTO.Roles.Add(role);

                    if (tmpAllInfoOfUserDTO.Courses == null)
                    {
                        tmpAllInfoOfUserDTO.Courses = new List<CourseInfoForUserDTO>();
                    }

                    tmpAllInfoOfUserDTO.Courses.Add(course);

                    if (tmpAllInfoOfUserDTO.Groups == null)
                    {
                        tmpAllInfoOfUserDTO.Groups = new List<GroupInfoForUserDTO>();
                    }

                    tmpAllInfoOfUserDTO.Groups.Add(group);

                    return tmpAllInfoOfUserDTO;
                },
                splitOn: "RoleId, CourseId, GroupId",
                commandType: CommandType.StoredProcedure);
            }

            return users;
        }

        public AllInfoOfUserDTO GetAllInfoOfUserById(int userId)
        {
            string expr = "[GetAllInfoOfUserById]";
            var value = new { userId };

            AllInfoOfUserDTO allInfoOfUser = null;



            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query<AllInfoOfUserDTO, RoleInfoForUserDTO, CourseInfoForUserDTO, GroupInfoForUserDTO, AllInfoOfUserDTO>(expr,
                (user, role, course, group) =>
                {
                    if (allInfoOfUser == null)
                    {
                        allInfoOfUser = user;
                    }

                    if (allInfoOfUser.Roles == null)
                    {
                        allInfoOfUser.Roles = new List<RoleInfoForUserDTO>();
                        allInfoOfUser.Roles.Add(role);
                    }
                    foreach (var r in allInfoOfUser.Roles)
                    {
                        if (r.RoleId != role.RoleId)
                        {
                            allInfoOfUser.Roles.Add(role);
                        }
                    }

                    if (allInfoOfUser.Courses == null)
                    {
                        allInfoOfUser.Courses = new List<CourseInfoForUserDTO>();
                    }
                    allInfoOfUser.Courses.Add(course);

                    if (allInfoOfUser.Groups == null)
                    {
                        allInfoOfUser.Groups = new List<GroupInfoForUserDTO>();
                    }
                    allInfoOfUser.Groups.Add(group);

                    return allInfoOfUser;
                },
                value,
                splitOn: "RoleId, CourseId, GroupId",
                commandType: CommandType.StoredProcedure);
            }

            return allInfoOfUser;
        }

        public LoginPassRoleDTO GetLoginPassRole(string login)
        {
            string expr = "GetLoginPassRole";
            var userAuthtorisInfo = new LoginPassRoleDTO();
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
                        userAuthtorisInfo = tmpLoginPassRole;
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
            return userAuthtorisInfo;
        }
        public void UpdateAllInfoOfUserById(AllInfoOfUserDTO allInfoOfUserDTO)
        {
            string expr = "[UpdateAllInfoOfUserById]";
            var value = new 
            {
                allInfoOfUserDTO.Id,
                allInfoOfUserDTO.FirstName,
                allInfoOfUserDTO.LastName,
                allInfoOfUserDTO.BirthDate,
                allInfoOfUserDTO.Login,
                allInfoOfUserDTO.Password,
                allInfoOfUserDTO.Email,
                allInfoOfUserDTO.Phone,
                allInfoOfUserDTO.ContractNumber,
                allInfoOfUserDTO.ProfileImage,
                allInfoOfUserDTO.StatusId
            };

            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }
        public void AddNewUser(AllInfoOfUserDTO allInfoOfUserDTO)
        {
            string expr = "[AddNewUser]";
            var value = new
            {
                allInfoOfUserDTO.FirstName,
                allInfoOfUserDTO.LastName,
                allInfoOfUserDTO.BirthDate,
                allInfoOfUserDTO.Login,
                allInfoOfUserDTO.Password,
                allInfoOfUserDTO.Email,
                allInfoOfUserDTO.Phone,
                allInfoOfUserDTO.ContractNumber,
                allInfoOfUserDTO.ProfileImage,
                allInfoOfUserDTO.StatusId
            };

            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
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

using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.DTO.Base;
using System.Collections.Generic;
using System.Data;
using Dapper;

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

        public Dictionary<int, SelectUserInfoByLoginDTO> SelectUserInfoByLogin( string login)
        {
            Dictionary<int, SelectUserInfoByLoginDTO> selectUserInfoByLogin = new Dictionary<int, SelectUserInfoByLoginDTO>();
            string expr = "[SelectUserInfoByLogin]";
            var value = new { Login = login };

            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query<SelectUserInfoByLoginDTO, RoleNameDTO, SelectUserInfoByLoginDTO>(expr, (userinfo, role) =>
                {
                    SelectUserInfoByLoginDTO selectUserInfoByLoginDTO;

                    if (!selectUserInfoByLogin.TryGetValue(userinfo.Id, out selectUserInfoByLoginDTO))
                    {
                        selectUserInfoByLoginDTO = userinfo;
                        selectUserInfoByLogin.Add(userinfo.Id, selectUserInfoByLoginDTO);
                    }

                    if (selectUserInfoByLoginDTO.Roles == null)
                    {
                        selectUserInfoByLoginDTO.Roles = new List<RoleNameDTO>();
                    }
                    if (role != null)
                    {
                        selectUserInfoByLoginDTO.Roles.Add(role);
                    }

                   return selectUserInfoByLoginDTO;
                },
            value, commandType: CommandType.StoredProcedure, splitOn: "RoleName");
            }
                return selectUserInfoByLogin;
            
        }

        public void UpdateUserProfile(int userId, string password, string phone, string email, string profileImage)
        {
            string expr = "[UpdateUserProfile]";
            var values = new { UserId = userId, NewPassword = password, NewPhone = phone, NewEmail = email, NewProfileImage = profileImage };
            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query(expr, values, commandType: CommandType.StoredProcedure);
            }
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

        public List<UserWithRoleAndStatusDTO> SelectNoStudentUsersWithRoleAndStatus()
        {
            var noStudentUserRoles = new List<UserWithRoleAndStatusDTO>();
            string expr = "[SelectNoStudentUsersWithRoleAndStatus]";
            using (var connection = SqlServerConnection.GetConnection())
            {
                noStudentUserRoles = connection.Query<UserWithRoleAndStatusDTO>(expr, commandType: CommandType.StoredProcedure).AsList<UserWithRoleAndStatusDTO>(); ;
            }
            return noStudentUserRoles;
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

                var UserDTO = connection.QuerySingle<UserDTO>("[User_SelectById]", new { id }, commandType: CommandType.StoredProcedure);
                return UserDTO;

            }
        }
    }
}

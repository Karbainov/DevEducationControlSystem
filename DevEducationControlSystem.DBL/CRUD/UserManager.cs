using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.DTO.Base;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class UserManager
    {


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
                var UserDTO = connection.QuerySingle<UserDTO>("[User_SelectById]",new { id }, commandType: CommandType.StoredProcedure);
                return UserDTO;
            }
        }
    }
}

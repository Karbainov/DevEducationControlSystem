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

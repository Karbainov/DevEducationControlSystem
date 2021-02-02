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
        public SqlConnection ConnectToDB()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
        public List<LessonAndFeedbackDTO> SelectLessonsAndFeedbackByUserId(int id)
        {
            var lessonsAndFeedbacks = new List<LessonAndFeedbackDTO>();
            string expr = "[SelectLessonsAndFeedbackByUserId]";
            var value = new {UserId = id };

            using (var connection = ConnectToDB())
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
                    tmpUserWithRole.Roles.Add(role);
                    return tmpUserWithRole;
                },
                value,
                splitOn: "RoleId",
                commandType: CommandType.StoredProcedure);
            }
            return users;
        }

        public List<LoginPassRoleDTO> GetLoginPassRole()
        {
            string expr = "GetLoginPassRole";
            var listUserAuthtorisInfo = new List<LoginPassRoleDTO>();

            using(var connection = SqlServerConnection.GetConnection())
            {
                connection.Query<LoginPassRoleDTO, RoleDTO, LoginPassRoleDTO>(expr,
                (user,role) =>
                {
                    LoginPassRoleDTO tmpLoginPassRole = null;

                    foreach(var r in listUserAuthtorisInfo)
                    {
                        if(r.UserId == user.UserId)
                        {
                            tmpLoginPassRole = r;
                            break;
                        }
                    }
                    if(tmpLoginPassRole == null)
                    {
                        tmpLoginPassRole = user;
                        listUserAuthtorisInfo.Add(tmpLoginPassRole);
                    }
                    tmpLoginPassRole.Roles.Add(role);
                    return tmpLoginPassRole;
                },
                splitOn: "Id",
                commandType: CommandType.StoredProcedure);
            }
            return listUserAuthtorisInfo;
        }
    }
}

using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;

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

        public Dictionary<int, SelectUserInfoByLoginDTO> SelectUserInfoByLogin( string login)
        {
            Dictionary<int, SelectUserInfoByLoginDTO> selectUserInfoByLogin = new Dictionary<int, SelectUserInfoByLoginDTO>();
            string expr = "[SelectUserInfoByLogin]";
            var value = new { Login = login };

            using (var connection = ConnectToDB())
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
            using (var connection = ConnectToDB())
            {
                connection.Query(expr, values, commandType CommandType.StoredProcedure);
            }
        }
    }
}

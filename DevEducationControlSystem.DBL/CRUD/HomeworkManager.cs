using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DevEducationControlSystem.DBL.DTO.Base;
using System.Data;
using Dapper;
using System.Linq;
using DevEducationControlSystem.DBL.DTO;



namespace DevEducationControlSystem.DBL.CRUD
{
    public class HomeworkManager
    {
        public List<HomeworkDTO> Select()
        {
            var howeworkList = SqlServerConnection.GetConnection().Query<HomeworkDTO>("Homework_Select", commandType: CommandType.StoredProcedure).ToList<HomeworkDTO>();
            return howeworkList;
        } 

       

        public HomeworkDTO SelectById(int id)
        {
            var homework = SqlServerConnection.GetConnection().QuerySingleOrDefault<HomeworkDTO>("Homework_SelectById", new { id }, commandType: CommandType.StoredProcedure);
            return homework;
        }

        public void Add(int resourceId, string name, string description, string isSolutionRequired)
        {
            var values = new { ResourceId = resourceId, Name = name, Description = description, IsSolutionRequired = isSolutionRequired };
            SqlServerConnection.GetConnection().Query("[Homework_Add]", values, commandType: CommandType.StoredProcedure);
        }

        public void Delete(int id)
        {
            SqlServerConnection.GetConnection().Query("[Homework_Delete]", new { id }, commandType: CommandType.StoredProcedure);
        }

        public void SoftDelete(int id)
        {
            SqlServerConnection.GetConnection().Query("[Homework_SoftDelete]", new { id }, commandType: CommandType.StoredProcedure);
        }

        public void Update(int id, int resourceId, string name, string description, string isDeleted, string isSolutionRequired)
        {
            var values = new { id, resourceId, name, description, isDeleted, isSolutionRequired };
            SqlServerConnection.GetConnection().Query("[Homework_Update]", values, commandType: CommandType.StoredProcedure);
        }



        public List<SelectAllHomeworkByThemeDTO> GetAllHomeworkByThemeId(int ThemeId)
        {
            List<SelectAllHomeworkByThemeDTO> homeworksByTheme = new List<SelectAllHomeworkByThemeDTO>();

            SqlServerConnection.GetConnection().Query<SelectAllHomeworkByThemeDTO, ResourceDTO, SelectAllHomeworkByThemeDTO>("[SelectAllHomeworkByThemeId]",
            (Homework, Resource) =>
                {
                    SelectAllHomeworkByThemeDTO homeworkTheme = new SelectAllHomeworkByThemeDTO();

                    foreach (var h in homeworksByTheme)
                    {
                        if (h.HomeworkId == homeworkTheme.HomeworkId)
                        {
                            homeworkTheme = h;
                            break;
                        }
                    };

                    if (homeworkTheme == null)
                    {
                        homeworkTheme = Homework;
                        homeworksByTheme.Add(homeworkTheme);
                    }

                    homeworkTheme.Resource.Add(Resource);
                    return homeworkTheme;


                }, ThemeId, commandType: CommandType.StoredProcedure, splitOn: "ResourceId").AsList<SelectAllHomeworkByThemeDTO>();

            return homeworksByTheme;
        }



        public List<SelectAllHomeworkByGroupDTO> GetAllHomeworkByGroupId(int GroupId)

        {
            List<SelectAllHomeworkByGroupDTO> homeworksByGroup = new List<SelectAllHomeworkByGroupDTO>();
            SqlServerConnection.GetConnection().Query<SelectAllHomeworkByGroupDTO, ResourceDTO, SelectAllHomeworkByGroupDTO>("[SelectAllHomeworkByGroupId]",
            (Homework, Resource) =>
            {
                SelectAllHomeworkByGroupDTO homeworkGroup = new SelectAllHomeworkByGroupDTO();
                foreach (var h in homeworksByGroup)
                {
                    if (h.HomeworkId == homeworkGroup.HomeworkId)
                    {
                        homeworkGroup = h;
                        break;
                    }
                };

                if (homeworkGroup == null)
                {
                    homeworkGroup = Homework;
                    homeworksByGroup.Add(homeworkGroup);
                }

                homeworkGroup.Resource.Add(Resource);

                return homeworkGroup;

            }, GroupId, commandType: CommandType.StoredProcedure, splitOn: "ResourceId").AsList<SelectAllHomeworkByGroupDTO>();

            return homeworksByGroup;

        }

        public List<SelectAllHomeworkByCourseDTO> GetAllHomeworkByCourse(int CourseId)
        {
            List<SelectAllHomeworkByCourseDTO> homeworksByCourse = new List<SelectAllHomeworkByCourseDTO>();

            SqlServerConnection.GetConnection().Query<SelectAllHomeworkByCourseDTO, ResourceDTO, SelectAllHomeworkByCourseDTO>("[SelectAllHomeworkByCourseId]",
            (Homework, Resource) =>
            {

                SelectAllHomeworkByCourseDTO homeworkCourse = new SelectAllHomeworkByCourseDTO();
                foreach (var h in homeworksByCourse)
                {
                    if (h.HomeworkId == homeworkCourse.HomeworkId)
                    {
                        homeworkCourse = h;
                        break;
                    }
                };

                if (homeworkCourse == null)
                {
                    homeworkCourse = Homework;
                    homeworksByCourse.Add(homeworkCourse);
                }

                homeworkCourse.Resource.Add(Resource);

                return homeworkCourse;

            }, CourseId, commandType: CommandType.StoredProcedure, splitOn: "ResourceId").AsList<SelectAllHomeworkByCourseDTO>();

            return homeworksByCourse;
        }


        public List<HomeworkAllInfoDTO> SelectAllHomeworkByGroupId(int groupId)
        {
            string expr = "[SelectAllHomeworkByGroupId]";
            var value = new { groupId };

            using (var connection = SqlServerConnection.GetConnection())
            {
                return connection.Query<HomeworkAllInfoDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<HomeworkAllInfoDTO>();
            }
        }

        public List<HomeworkWithStatusesDTO> SelectHomeworkWithStatusesByUserId(int userId)
        {
            string expr = "[SelectHomeworkWithStatusesByUserId]";
            var value = new { userId };

            using (var connection = SqlServerConnection.GetConnection())
            {
                return connection.Query<HomeworkWithStatusesDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<HomeworkWithStatusesDTO>();
            }
        }

        public List<HomeworkDTO> SelectSoftDeleted()
        {
            var howeworkList = SqlServerConnection.GetConnection().Query<HomeworkDTO>("Homework_SelectSoftDeleted", commandType: CommandType.StoredProcedure).ToList<HomeworkDTO>();
            return howeworkList;
        }


        public void UpdateIsDeleted(int id)
        {
            var howeworkList = SqlServerConnection.GetConnection().Query("Homework_RecoverSoftDeleted", new { id }, commandType: CommandType.StoredProcedure);
        }


    }
}
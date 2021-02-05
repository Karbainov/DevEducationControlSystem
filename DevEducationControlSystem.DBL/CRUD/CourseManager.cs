using Dapper;
using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class CourseManager
    {
        public List<CourseInCurrentCityDTO> GetAllCoursesInCurrentCityById(int id)
        {
            var AllCoursesInCurrentCity = new List<CourseInCurrentCityDTO>();
            string expr = "[GetAllCoursesInCurrentCityById]";
            var value = new { id };

            using (var connection = SqlServerConnection.GetConnection())
            {
                AllCoursesInCurrentCity = connection.Query<CourseInCurrentCityDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<CourseInCurrentCityDTO>(); ;
            }
            return AllCoursesInCurrentCity;
        }
        public List<CourseByTagNameDTO> SelectCourseByTagName(string name)
        {
            var courseByTag = new List<CourseByTagNameDTO>();
            string expr = "[SelectCourseByTagName]";
            var value = new { name };
            using (var connection = SqlServerConnection.GetConnection())
            {
                return connection.Query<CourseByTagNameDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList();
            }
        }

        public List<CourseByTagIdDTO> SelectCourseByTagId(int id)
        {
            var courseByTag = new List<CourseByTagIdDTO>();
            string expr = "[SelectCourseByTagId]";
            var value = new { id };
            using (var connection = SqlServerConnection.GetConnection())
            {
                return connection.Query<CourseByTagIdDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList();
            }
        }

        public void Add(string name, string description, int durationInWeeks)
        {
            string expression = "[Course_Add]";
            var parameter = new
            {
                Name = name,
                Description = description,
                DurationInWeeks = durationInWeeks
            };
            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query(expression, parameter, commandType: CommandType.StoredProcedure);
            }
        }
        public List<CourseDTO> Select()
        {
            var courseDTOs = new List<CourseDTO>();
            string expression = "[Course_Select]";
            using (var connection = SqlServerConnection.GetConnection())
            {
                courseDTOs = connection.Query<CourseDTO>(expression, commandType: CommandType.StoredProcedure).ToList<CourseDTO>();
            }
            return courseDTOs;
        } 

        

        public CourseDTO SelectById(int id)
        {
            var courseDTO = new CourseDTO();
            string expression = "[Course_SelectById]";
            var parameter = new { Id = id };
            using (var connection = SqlServerConnection.GetConnection())
            {
                courseDTO = connection.QuerySingle<CourseDTO>(expression, parameter, commandType: CommandType.StoredProcedure);
            }
            return courseDTO;
        }
        public void Update(int id, string name, string description, int durationInWeeks, bool isDeleted)
        {
            string expression = "[Course_Update]";
            var parameter = new
            {
                Id = id,
                Name = name,
                Description = description,
                DurationInWeeks = durationInWeeks,
                IsDeleted = isDeleted
            };
            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query(expression, parameter, commandType: CommandType.StoredProcedure);
            }
        }
        public void Delete(int id)
        {
            string expression = "[Course_Delete]";
            var parameter = new  { Id = id };
            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query(expression, parameter, commandType: CommandType.StoredProcedure);
            }
        }
        public CourseOverlookDTO SelectCourseGeneralInfoByStudentId(int studentId)
        {
            CourseOverlookDTO courseGeneralInfo = null;
            string expression = "[SelectCourseGeneralInfoByStudentId]";
            var parameter = new { UserId = studentId };
            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query<CourseOverlookDTO, GroupmatesDTO, CourseOverlookDTO>(expression, (CourseGeneralInfo, PublicStudenInfo) =>
                {
                    if (courseGeneralInfo == null)
                    {
                        courseGeneralInfo = CourseGeneralInfo;
                    }

                    if (courseGeneralInfo.GroupmatesDTOs == null)
                    {
                        courseGeneralInfo.GroupmatesDTOs = new List<GroupmatesDTO>();
                    }

                    courseGeneralInfo.GroupmatesDTOs.Add(PublicStudenInfo);
                    
                    return courseGeneralInfo;
                },
                parameter, commandType: CommandType.StoredProcedure, splitOn: "StudentId");
            }
             return courseGeneralInfo;
        }

        public List<CourseDTO> SelectSoftDeleted()
        {
            var courseDTOs = new List<CourseDTO>();
            string expression = "[Course_SelectSoftDeleted]";
            using (var connection = SqlServerConnection.GetConnection())
            {
                courseDTOs = connection.Query<CourseDTO>(expression, commandType: CommandType.StoredProcedure).ToList<CourseDTO>();
            }
            return courseDTOs;
        }

        public void UpdateIsDeleted(int id)
        {
            var CourseList = SqlServerConnection.GetConnection().Query("Course_RecoverSoftDeleted", new { id }, commandType: CommandType.StoredProcedure);
        }

        public int AddReturnId(string name, string description, int durationInWeeks)
        {
            string expression = "[Course_Add_ReturnId]";
            var parameter = new
            {
                Name = name,
                Description = description,
                DurationInWeeks = durationInWeeks
            };
            using (var connection = SqlServerConnection.GetConnection())
            {
                var id = connection.QueryFirst<int>(expression, parameter, commandType: CommandType.StoredProcedure);
                return id;
            }
        }

        public int UpdateReturnId(int id, string name, string description, int durationInWeeks, bool isDeleted)
        {
            string expression = "[Course_Update_ReturnId]";
            var parameter = new
            {
                Id = id,
                Name = name,
                Description = description,
                DurationInWeeks = durationInWeeks,
                IsDeleted = isDeleted
            };
            using (var connection = SqlServerConnection.GetConnection())
            {
                var Id = connection.QueryFirst<int>(expression, parameter, commandType: CommandType.StoredProcedure);
                return Id;
            }
        }
        public int DeleteReturnId(int id)
        {
            string expression = "[Course_SoftDelete_ReturnId]";
            var parameter = new { id };
            using (var connection = SqlServerConnection.GetConnection())
            {
                var Id = connection.QueryFirst<int>(expression, parameter, commandType: CommandType.StoredProcedure);
                return Id;
            }
        }

    }
}

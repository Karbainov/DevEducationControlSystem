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

        public List<HomeworkAllInfoDTO> SelectAllHomeworkByGroupId(int groupId)
        {
            string expr = "[SelectAllHomeworkByGroupId]";
            var value = new { groupId };

            using (var connection = SqlServerConnection.GetConnection())
            {
                return connection.Query<HomeworkAllInfoDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<HomeworkAllInfoDTO>();
            }
        }
    }
}
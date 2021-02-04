using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using DevEducationControlSystem.DBL.DTO.Base;
using DevEducationControlSystem.DBL.DTO;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class SelectGroupsOnCoursesInfoModelManager
    {
        public SelectGroupsOnCoursesInfoDTO SelectGroupInfoById(int groupId)
        {
            string sqlExpression = "[SelectGroupsOnCoursesInfo]";
            var value = new { groupId };
            using (var connection = SqlServerConnection.GetConnection())
            {
                return connection.QuerySingle<SelectGroupsOnCoursesInfoDTO>(sqlExpression, value, commandType: CommandType.StoredProcedure);
            }
        }
    }
}

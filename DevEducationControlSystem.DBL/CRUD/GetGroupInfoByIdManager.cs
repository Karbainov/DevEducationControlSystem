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
    public class GetGroupInfoByIdManager
    {
        public GetGroupInfoByIdDTO SelectGroupInfoById(int groupId)
        {
            string sqlExpression = "[GetGroupInfoById]";
            var value = new { groupId };
            using (var connection = SqlServerConnection.GetConnection())
            {
                return connection.QuerySingle<GetGroupInfoByIdDTO>(sqlExpression, value, commandType: CommandType.StoredProcedure);
            }
        }
    }
}

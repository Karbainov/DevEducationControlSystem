using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;
using DevEducationControlSystem.DBL.DTO.Base;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class Group_MaterialManager
    {
        public SqlConnection ConnectToDB()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
        public List<Group_MaterialDTO> Select()
        {
            var groups = new List<Group_MaterialDTO>();
            string expr = "[Group_Material_Select]";
            using (var connection = ConnectToDB())
            {
                groups = connection.Query<Group_MaterialDTO>(expr, commandType: CommandType.StoredProcedure).AsList< Group_MaterialDTO>();
            }
            return groups;
        }

        public Group_MaterialDTO SelectById(int id)
        {
            Group_MaterialDTO group = new Group_MaterialDTO();
            string expr = "[Group_Material_SelectById]";
            var value = new { id = id };
            using (var connection = ConnectToDB())
            {
                var groups = connection.Query<Group_MaterialDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<Group_MaterialDTO>();
                if (groups.Count > 0)
                {
                    group = groups[0];
                }
            }
            return group;
        }

        public void Add(int groupId, int materialId)
        {
            string expr = "[Group_Material_Add]";
            var value = new { GroupId = groupId, MaterialId = materialId};

            using (var connection = ConnectToDB())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int id)
        {
            string expr = "[Group_Material_Delete]";
            var value = new { Id = id };

            using (var connection = ConnectToDB())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(int id, int groupId, int materialId)
        {
            string expr = "[Group_Material_Update]";
            var value = new { Id = id, GroupId = groupId, MaterialId = materialId };

            using (var connection = ConnectToDB())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }
    }
}

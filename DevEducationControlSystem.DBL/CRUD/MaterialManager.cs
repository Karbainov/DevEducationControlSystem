using System;
using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.DTO.Base;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class MaterialManager
    {
        string _connectionString;
        SqlConnection _connection;

        public MaterialManager()
        {
            _connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
        }
        public List<MaterialDTO> Select()
        {
            List<MaterialDTO> materials = new List<MaterialDTO>();
            _connection = new SqlConnection(_connectionString);
            try
            {
                _connection.Open();
            }
            catch
            {
                _connection.Close();
                throw new Exception("Failed to connect");
            }
            string sqlExpression = "Material_Select";
            SqlCommand command = new SqlCommand(sqlExpression, _connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = (int)reader["Id"];
                    int userid = (int)reader["UserId"];
                    int resourceid = (int)reader["ResouceId"];
                    string name = (string)reader["Name"];
                    string message = (string)reader["Message"];
                    bool isdeleted = (bool)reader["IsDeleted"];
                    materials.Add(new MaterialDTO(id, userid, resourceid, name, message, isdeleted));
                }
            }
            reader.Close();
            _connection.Close();

            return materials;
        }

        public MaterialDTO SelectById(int Id)
        {
            MaterialDTO material = new MaterialDTO();
            _connection = new SqlConnection(_connectionString);
            try
            {
                _connection.Open();
            }
            catch
            {
                _connection.Close();
                throw new Exception("Failed to connect");
            }

            string sqlExpression = "Material_SelectById";
            SqlCommand command = new SqlCommand(sqlExpression, _connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter idParam = new SqlParameter("@Id", Id);
            command.Parameters.Add(idParam);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = (int)reader["Id"];
                    int userid = (int)reader["UserId"];
                    int resourceid = (int)reader["ResouceId"];
                    string name = (string)reader["Name"];
                    string message = (string)reader["Message"];
                    bool isdeleted = (bool)reader["IsDeleted"];
                    material = new MaterialDTO(id, userid, resourceid, name, message, isdeleted);
                }
            }
            reader.Close();
            _connection.Close();

            return material;
        }

        public List<AllGroupMaterialsByTagAndUserIdDTO> Get(int userId, string tagName)
        {
            List<AllGroupMaterialsByTagAndUserIdDTO> materialsByTag = new List<AllGroupMaterialsByTagAndUserIdDTO>();
            string expr = "[GetAllGroupMaterialsByTagAndUserId]";
            var value = new { UserId = userId, TagName = tagName };
            using (_connection = new SqlConnection(_connectionString))
            {
                materialsByTag = _connection.Query<AllGroupMaterialsByTagAndUserIdDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<AllGroupMaterialsByTagAndUserIdDTO>();
            }
            return materialsByTag;
        }

    }
}

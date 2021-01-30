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
        public SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

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
                    int resourceid = (int)reader["ResourceId"];
                    string name = (string)reader["Name"];
                    string message;
                    if (!reader.IsDBNull(reader.GetOrdinal("Message")))
                    {
                        message = (string)reader["Message"];
                    }
                    else
                    {
                        message = null;
                    }
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
                    int resourceid = (int)reader["ResourceId"];
                    string name = (string)reader["Name"];
                    string message;
                    if (!reader.IsDBNull(reader.GetOrdinal("Message")))
                    {
                        message = (string)reader["Message"];
                    }
                    else
                    {
                        message = null;
                    }
                    bool isdeleted = (bool)reader["IsDeleted"];
                    material = new MaterialDTO(id, userid, resourceid, name, message, isdeleted);
                }
            }
            reader.Close();
            _connection.Close();

            return material;
        }

        public void Add(string name)
        {
            string expr = "[Material_Add]";
            var value = new { Name = name };
            using (var connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int id)
        {
            string expr = "[Material_Delete]";
            var value = new { Id = id };
            using (var connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void SoftDelete(int id)
        {
            string expr = "[Material_SoftDelete]";
            var value = new { Id = id };
            using (var connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update(int id, string name)
        {
            string expr = "[Material_Update]";
            var value = new { Id = id, Name = name };
            using (var connection = GetConnection())
            {
                connection.Query(expr, value, commandType: CommandType.StoredProcedure);
            }
        }

        public List<UnlockedMaterialsWithTagsByUserIdAndTagDTO> GetUnlockedMaterialsWithTagsByUserIdAndTag(int userId, string tagName)
        {
            List<UnlockedMaterialsWithTagsByUserIdAndTagDTO> materialsByTag = new List<UnlockedMaterialsWithTagsByUserIdAndTagDTO>();
            string expr = "[SelectUnlockedMaterialsWithTagsByUserIdAndTag]";
            var values = new { UserId = userId, Tag = tagName };
            using (var connection = SqlServerConnection.GetConnection())
            {
                connection.Query<UnlockedMaterialsWithTagsByUserIdAndTagDTO, string, UnlockedMaterialsWithTagsByUserIdAndTagDTO>(expr,(Material, Tag)=>
                {
                    UnlockedMaterialsWithTagsByUserIdAndTagDTO material = null;
                    
                        foreach (var m in materialsByTag)
                        {
                            if (Material.MaterialId == m.MaterialId)
                            {
                                material = m;
                                break;
                            }
                        }
                    

                    if (material==null)
                    {
                        material = Material;
                        materialsByTag.Add(material);
                    }

                    if (material.TagName == null) material.TagName = new List<string>();

                    material.TagName.Add(Tag);

                    return material;
                },
                    
                    values, commandType: CommandType.StoredProcedure, splitOn: "TagName" );
            }
            return materialsByTag;
        }

        public List<MaterialsInfoForGroupDTO> SelectMaterialsInfoForGroup(int groupId)
        {
            string expr = "[SelectAllMaterialsByGroupId]";
            var value = new { groupId };
            using (var connection = SqlServerConnection.GetConnection())
            {
                return connection.Query<MaterialsInfoForGroupDTO>(expr, value, commandType: CommandType.StoredProcedure).AsList<MaterialsInfoForGroupDTO>();
            }
        }



    }
}

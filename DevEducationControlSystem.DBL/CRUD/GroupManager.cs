using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class GroupManager
    {
        public SqlConnection ConnectToDB()
        {
            string connectionString = @"Data Source=80.78.240.16; Initial Catalog=DevEdControl.Test;User Id=devEd; Password=qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
        public List<GroupDTO> Select()
        {
            List<GroupDTO> groups = new List<GroupDTO>();
            SqlConnection connection = ConnectToDB();
            connection.Open();

            string sqlExpression = "Group_Select";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader reader = command.ExecuteReader();


            if (reader.HasRows) 
            {
                while (reader.Read()) 
                {
                    int id = (int)reader["Id"];
                    int statusId = (int)reader["StatusId"];
                    int courseId = (int)reader["CourseId"];
                    int cityId = (int)reader["CityId"];
                    string name = (string)reader["Name"];
                    DateTime startDate = (DateTime)reader["StartDate"];
                    groups.Add(new GroupDTO(id, statusId, courseId, cityId, name, startDate));
                }
            }
            reader.Close();
            connection.Close();
            return groups;
        }

        public GroupDTO SelectById(int id)
        {
            GroupDTO group = new GroupDTO();
            SqlConnection connection = ConnectToDB();
            connection.Open();

            string sqlExpression = "Group_SelectById";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter idParameter = new SqlParameter("@Id", id);
            command.Parameters.Add(idParameter);

            SqlDataReader reader = command.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int groupId = (int)reader["Id"];
                    int statusId = (int)reader["StatusId"];
                    int courseId = (int)reader["CourseId"];
                    int cityId = (int)reader["CityId"];
                    string name = (string)reader["Name"];
                    DateTime startDate = (DateTime)reader["StartDate"];
                    group = new GroupDTO(groupId, statusId, courseId, cityId, name, startDate);
                }
            }
            reader.Close();           
            connection.Close();
            return group;
        }
    }
}

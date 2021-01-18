using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class TagManager
    {
        public List<TagDTO> Select()
        {
            List<TagDTO> TagDTOs = new List<TagDTO>();
            TagDTO tagDTO= new TagDTO();

            string connectionString = @"Data Sourse=80.78.240.16; initial catalog = DevEdControl.Test; UserId=DevEd; Password=qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);

            string sqlExpression = "SELECT * FROM Tag";

            connection.Open();

            SqlCommand command = new SqlCommand(sqlExpression, connection);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tagDTO.Id = reader.GetInt32(0);
                    tagDTO.Name = reader.GetString(1);
                    TagDTOs.Add(tagDTO);
                    //Console.WriteLine($"\t{tagDTO.Id }\t{ tagDTO.Name}");
                }                           
            }
            reader.Close();
            connection.Close();
            return TagDTOs;
        }

        public TagDTO SelectById(int 2)
        {
            TagDTO tagDTO = new TagDTO();
            string connectionString = @"Data Sourse=80.78.240.16; initial catalog = DevEdControl.Test; UserId=DevEd; Password=qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);

            string sqlExpression = "SELECT * FROM Tag"+id;

            connection.Open();

            SqlCommand command = new SqlCommand(sqlExpression, connection);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                tagDTO.Id = reader.GetInt32(0);
                tagDTO.Name = reader.GetString(1);
                Console.WriteLine($"\t{tagDTO.Id }\t{ tagDTO.Name}");
            }
            reader.Close();
            connection.Close();
            return tagDTO;
        }
    }
}

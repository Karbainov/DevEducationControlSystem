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
            string connectionString = @"Data Sourse=80.78.240.16; initial catalog = DevEdControl.Test; UserId=DevEd; Password=qqq!11";
            SqlConnection connection = new SqlConnection(connectionString);
            
            List<TagDTO> TagDTOs = new List<TagDTO>();

            //Тут как-то заполняется
            return TagDTOs;
        }

        public TagDTO SelectById(int id)
        {
            TagDTO tagDTO = new TagDTO();
            //Тут как-то заполняется
            return tagDTO;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class TagDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public TagDTO()
        {

        }

        public TagDTO(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

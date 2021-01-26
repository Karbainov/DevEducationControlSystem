using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class RoleDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public RoleDTO()
        {

        }

        public RoleDTO ( int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}

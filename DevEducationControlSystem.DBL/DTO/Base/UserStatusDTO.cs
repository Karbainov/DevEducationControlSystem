using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class UserStatusDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public UserStatusDTO()
        {

        }

        public UserStatusDTO(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

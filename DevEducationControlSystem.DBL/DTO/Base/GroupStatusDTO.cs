using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class GroupStatusDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GroupStatusDTO()
        {

        }

        public GroupStatusDTO(int id, string name)
        {
            id = Id;
            name = Name;
        }
    }
}

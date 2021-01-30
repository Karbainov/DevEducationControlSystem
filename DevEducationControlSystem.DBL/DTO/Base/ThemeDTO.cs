using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class ThemeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ThemeDTO()
        {

        }

        public ThemeDTO(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }


}

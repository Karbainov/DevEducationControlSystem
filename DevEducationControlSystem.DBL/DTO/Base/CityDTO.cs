using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class CityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CityDTO()
        {

        }

        public CityDTO(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

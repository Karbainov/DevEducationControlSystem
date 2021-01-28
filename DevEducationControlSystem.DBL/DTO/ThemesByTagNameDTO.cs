using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class ThemesByTagNameDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ThemesByTagNameDTO()
        {

        }

        public ThemesByTagNameDTO(ThemesByTagNameDTO dto)
        {
            Id = dto.Id;
            Name = dto.Name;
        }
    }
}

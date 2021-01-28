using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class ThemesByTagIdDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ThemesByTagIdDTO()
        {

        }

        public ThemesByTagIdDTO(ThemesByTagNameDTO dto)
        {
            Id = dto.Id;
            Name = dto.Name;
        }
    }
}

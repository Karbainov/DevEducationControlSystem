using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class SelectThemesByTagIdDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public SelectThemesByTagIdDTO()
        {

        }

        public SelectThemesByTagIdDTO(SelectThemesByTagNameDTO dto)
        {
            Id = dto.Id;
            Name = dto.Name;
        }
    }
}

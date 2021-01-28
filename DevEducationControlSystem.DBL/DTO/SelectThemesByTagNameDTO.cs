using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class SelectThemesByTagNameDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public SelectThemesByTagNameDTO()
        {

        }

        public SelectThemesByTagNameDTO(SelectThemesByTagNameDTO dto)
        {
            Id = dto.Id;
            Name = dto.Name;
        }
    }
}

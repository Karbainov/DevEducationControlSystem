using System;
using System.Collections.Generic;
using System.Text;


namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class Theme_MaterialDTO
    {
        public int Id { get; set; }
        public int ThemeId { get; set; }
        public int MaterialId { get; set; }

        public Theme_MaterialDTO()

        {

        }

        public Theme_MaterialDTO(int id, int themeId, int materialId)

        {
            Id = id;
            ThemeId = themeId;
            MaterialId = materialId;
        }
    }
}

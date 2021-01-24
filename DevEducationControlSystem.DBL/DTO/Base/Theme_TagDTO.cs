using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class Theme_TagDTO
    {

        public int Id { get; set; }
        public int ThemeId { get; set; }
        public int TagId { get; set; }

        public Theme_TagDTO()
        {

        }

        public Theme_TagDTO(int id, int themeId, int tagId)
        {
            Id = id;
            ThemeId = themeId;
            TagId = tagId;
        }
    }
}

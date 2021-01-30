using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class OneUnlockedMaterialByTagModel
    {
        public int MaterialId { get; set; }
        public string MaterialName { get; set; }
        public string Message { get; set; }
        public string Links { get; set; }
        public string Images { get; set; }
        public List<string> TagName { get; set; }
        public OneUnlockedMaterialByTagModel(UnlockedMaterialsWithTagsByUserIdAndTagDTO dto)
        {
            Images = dto.Images;
            Links = dto.Links;
            MaterialId = dto.MaterialId;
            MaterialName = dto.MaterialName;
            Message = dto.Message;
            TagName = dto.TagName;
        }
    }
}

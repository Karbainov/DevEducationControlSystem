using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Mappers
{
    public class UnlockedMaterialsWithTagsByUserIdAndTagDTOtoUnlockedMaterialsByTagModelMapper
    {
        public ListOfUnlockedMaterialsByTagModel Map(List<UnlockedMaterialsWithTagsByUserIdAndTagDTO> dto)
        {
            var materials = new ListOfUnlockedMaterialsByTagModel();
            materials.materialWithTagList = new List<OneUnlockedMaterialByTagModel>();
            
            foreach (var m in dto)
            {
                materials.materialWithTagList.Add(new OneUnlockedMaterialByTagModel(m));
            }

            return materials;
        }
    }
}

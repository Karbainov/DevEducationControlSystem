using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Mappers
{
    class ThemeDTOMaterialDtosToThemeInfoModelMapper
    {
        public ThemeInfoModel Map(ThemeDTO themeDTO, List<MaterialDTO> materialDTOs)
        {
            var themeInfoModel = new ThemeInfoModel()
            {
                Id = themeDTO.Id,
                Materials = new List<MaterialInfoModel>()
            };
            return themeInfoModel;
        }
    }
}

using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class RoleModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        public RoleModel()
        {

        }
        public RoleModel(RoleDTO dto)
        {
            Id = dto.Id;
            Name = dto.Name;
        }

    }
}

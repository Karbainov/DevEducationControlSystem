using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.DBL.DTO;

namespace DevEducationControlSystem.BLL.Models
{
    public class RoleStatisticModel
    {
        public string Role { get; set; }
        public int NumberOfPeople { get; set; }

        public RoleStatisticModel()
        { }

        public RoleStatisticModel(NumberOfPeoplePerRoleDTO dto)
        {
            Role = dto.Role;
            NumberOfPeople = dto.NumberOfPeople;
        }
    }
}

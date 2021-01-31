using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Mappers
{
    public class RoleStatisticMapper
    {
        public List<RoleStatisticModel> Map(List<NumberOfPeoplePerRoleDTO> dto)
        {
            var list = new List<RoleStatisticModel>();
            

            foreach (var m in dto)
            {
                list.Add(new RoleStatisticModel(m));
            }

            return list;
        }
    }
}

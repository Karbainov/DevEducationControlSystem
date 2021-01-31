using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Mappers
{
    public class RoleStatisticMapper
    {
        public ListRoleStatisticModel Map(List<NumberOfPeoplePerRoleDTO> dto)
        {
            var list = new ListRoleStatisticModel();
            list.listRoleStatistic = new List<RoleStatisticModel>();

            foreach (var m in dto)
            {
                list.listRoleStatistic.Add(new RoleStatisticModel(m));
            }

            return list;
        }
    }
}

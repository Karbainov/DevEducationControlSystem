using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Mappers
{
    public class HomeworkWithStatusMapper
    {
        public List<HomeworkWithStatusModel> Map(List<HomeworkWithStatusesDTO> dto)
        {
            var list = new List<HomeworkWithStatusModel>();

            foreach (var m in dto)
            {
                list.Add(new HomeworkWithStatusModel(m));
            }

            return list;
        }
    }
}

using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Mappers
{
    public class HomeworkWithStatusMapper
    {
        public HomeworkWithStatusModel Map(HomeworkWithStatusesDTO dto)
        {
            return new HomeworkWithStatusModel()
            {
                HomeworkName = dto.HomeworkName,
                HomeworkStatus = dto.HomeworkStatus,
                Description = dto.Description,
                Links = dto.Links,
                Images = dto.Images,
                AnswerDate = dto.AnswerDate
            };
            
        }
    }
}

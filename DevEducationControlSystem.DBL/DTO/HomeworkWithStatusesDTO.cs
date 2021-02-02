using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class HomeworkWithStatusesDTO
    {
        public string HomeworkName { get; set; }
        public string HomeworkStatus { get; set; }
        public string Description { get; set; }
        public string Links { get; set; }
        public string Images { get; set; }
        public DateTime AnswerDate { get; set; }

        public HomeworkWithStatusesDTO()
        {

        }

        public HomeworkWithStatusesDTO(HomeworkWithStatusesDTO dto)
        {
            HomeworkName = dto.HomeworkName;
            HomeworkStatus = dto.HomeworkStatus;
            Description = dto.Description;
            Links = dto.Links;
            Images = dto.Images;
            AnswerDate = dto.AnswerDate;
        }
    }
}

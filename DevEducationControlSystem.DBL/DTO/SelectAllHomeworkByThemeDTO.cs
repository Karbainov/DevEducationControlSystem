using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class SelectAllHomeworkByThemeDTO
    {
        public int HomeworkId { get; set; }
        public string Homework { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DeadLine { get; set; }
        public List<ResourceDTO> Resource { get; set; }

        public SelectAllHomeworkByThemeDTO()
        {

        }
        public SelectAllHomeworkByThemeDTO(SelectAllHomeworkByThemeDTO dto)
        {
            HomeworkId = dto.HomeworkId;
            Homework = dto.Homework;
            Description = dto.Description;
            Resource = dto.Resource;
        }
    }
}

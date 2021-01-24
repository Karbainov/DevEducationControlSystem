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
        public ResourceLinksDTO ResourceLinks { get; set; }
        public ResourceLinksDTO ResourceImage { get; set; }

        public SelectAllHomeworkByThemeDTO()
        {

        }
        public SelectAllHomeworkByThemeDTO(SelectAllHomeworkByThemeDTO dto)
        {
            HomeworkId = dto.HomeworkId;
            Homework = dto.Homework;
            Description = dto.Description;
            ResourceLinks = dto.ResourceLinks;
            ResourceImage = dto.ResourceImage;
        }
    }
}

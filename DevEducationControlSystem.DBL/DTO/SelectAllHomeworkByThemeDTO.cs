using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    class SelectAllHomeworkByThemeDTO
    {
        public int HomeworkId { get; set; }
        public string Homework { get; set; }
        public string Description { get; set; }
        public string ResourceLinks { get; set; }
        public string ResourceImage { get; set; }
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

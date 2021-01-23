using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class SelectAllHomeworkByCourseDTO
    {
        public int HomeworkId { get; set; }
        public string Homework { get; set; }
        public string Description { get; set; }
        public string ResourceLinks { get; set; }
        public string ResourceImage { get; set; }
        public SelectAllHomeworkByCourseDTO()
        {

        }
        public SelectAllHomeworkByCourseDTO(SelectAllHomeworkByCourseDTO dto)
        {
            HomeworkId = dto.HomeworkId;
            Homework = dto.Homework;
            Description = dto.Description;
            ResourceLinks = dto.ResourceLinks;
            ResourceImage = dto.ResourceImage;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class LessonDTO
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public DateTime LessonDate { get; set; }
        public string Comments { get; set; }

        public LessonDTO()
        {

        }

        public LessonDTO(
            int id,
            int groupId,
            string name,
            DateTime lessonDate,
            string comments)
        {
            Id = id;
            GroupId = groupId;
            Name = name;
            LessonDate = lessonDate;
            Comments = comments;
        }
    }
}

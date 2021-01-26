using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class AttendanceDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int LessonId { get; set; }
        public bool IsPresent { get; set; }

        public AttendanceDTO()
        {

        }

        public AttendanceDTO (int id, int userId, int lessonId, bool isPresent)
        {
            Id = id;
            UserId = userId;
            LessonId = lessonId;
            IsPresent = isPresent;
            
        }


    }

    

}

using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class LessonAttendanceDTO
    {
        public int LessonId { get; set; }
        public string Lesson { get; set; }
        public DateTime LessonDate { get; set; }
        public int GroupId { get; set; }
        public string Group { get; set; }
        public List<AttendanceDTO> Attendances { get;set;}

    }
}

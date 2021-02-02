using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class LessonAttendanceModel
    {
        public int LessonId { get; set; }
        public string Lesson { get; set; }
        public DateTime LessonDate { get; set; }
        public int GroupId { get; set; }
        public string Group { get; set; }
        public List<AttendanceModel> Attendances { get; set; }


        public LessonAttendanceModel(
            LessonAttendanceDTO lessonAttendanceDTO)
        {
            LessonId = lessonAttendanceDTO.LessonId;
            Lesson = lessonAttendanceDTO.Lesson;
            LessonDate = lessonAttendanceDTO.LessonDate;
            GroupId = lessonAttendanceDTO.GroupId;
            Group = lessonAttendanceDTO.Group;
            Attendances = new List<AttendanceModel>();
            lessonAttendanceDTO.Attendances.ForEach((r) => 
            { 
                Attendances.Add(r != null ? new AttendanceModel(r) : null); 
            });
        }
    }
}

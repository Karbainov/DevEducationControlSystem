using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.DBL.DTO;

namespace DevEducationControlSystem.BLL.Models
{
    public class CourseOverlookModel
    {
        public int CourseId;
        public string CourseName;
        public DateTime CourseStartDate;
        public int DurationInWeeks;
        public DateTime CourseEndDate;
        public int GroupId;
        public string GroupName;
        public int TeacherId;
        public string TeacherFirstName;
        public string TeacherLastName;
        public int TutorId;
        public string TutorFirstName;
        public string TutorLastName;

        public CourseOverlookModel(CourseOverlookDTO dto)
        {
            CourseId = dto.CourseId;
            CourseName = dto.CourseName;
            CourseStartDate = dto.CourseStartDate;
            DurationInWeeks = dto.DurationInWeeks;
            CourseEndDate = CourseStartDate.AddDays(DurationInWeeks * 7);
            GroupId = dto.GroupId;
            GroupName = dto.GroupName;
            TeacherId = dto.TeacherId;
            TeacherFirstName = dto.TeacherFirstName;
            TeacherLastName = dto.TeacherLastName;
            TutorId = dto.TutorId;
            TutorFirstName = dto.TutorFirstName;
            TutorLastName = dto.TutorLastName;
        
        }
    }
}

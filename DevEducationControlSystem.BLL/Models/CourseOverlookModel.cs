using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.DBL.DTO;

namespace DevEducationControlSystem.BLL.Models
{
    public class CourseOverlookModel
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public DateTime CourseStartDate { get; set; }
        public int DurationInWeeks { get; set; }
        public DateTime CourseEndDate { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int TeacherId { get; set; }
        public string TeacherFirstName { get; set; }
        public string TeacherLastName { get; set; }
        public int TutorId { get; set; }
        public string TutorFirstName { get; set; }
        public string TutorLastName { get; set; }
        public List<GroupmatesModel> Groupmates { get; set; }

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

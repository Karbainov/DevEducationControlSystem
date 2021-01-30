using System;
using System.Collections.Generic;
using System.Text;


namespace DevEducationControlSystem.DBL.DTO
{
    public class CourseOverlookDTO
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public DateTime CourseStartDate { get; set; }
        public int DurationInWeeks { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int TeacherId { get; set; }
        public string TeacherFirstName { get; set; }
        public string TeacherLastName { get; set; }
        public int TutorId { get; set; }
        public string TutorFirstName { get; set; }
        public string TutorLastName { get; set; }
        public List<GroupmatesDTO> GroupmatesDTOs { get; set; }
    }
}

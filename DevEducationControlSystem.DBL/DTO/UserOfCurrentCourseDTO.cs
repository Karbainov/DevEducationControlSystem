using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class UserOfCurrentCourseDTO
    {
        public int CourseId { get; set; }
        public string Course { get; set; }
        public int UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public UserOfCurrentCourseDTO()
        {

        }
        public UserOfCurrentCourseDTO(int CourseId, string Course, int UserId, string Firstname, string Lastname, int StatusId, string Status)
        {
            this.CourseId = CourseId;
            this.Course = Course;
            this.UserId = UserId;
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.StatusId = StatusId;
            this.Status = Status;
        }
    }
}

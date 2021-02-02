using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class CourseOfCurrentUserDTO
    {
        public int UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public int CourseId { get; set; }
        public string Course { get; set; }
        public CourseOfCurrentUserDTO()
        {

        }
        public CourseOfCurrentUserDTO(int userId, string firstname, string lastname, int statusId, string status, int courseId, string course)
        {
            UserId = userId;
            Firstname = firstname;
            Lastname = lastname;
            StatusId = statusId;
            Status = status;
            CourseId = courseId;
            Course = course;
        }
    }
}

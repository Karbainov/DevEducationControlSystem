using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class CourseDurationOfCurrentStudentDTO
    {
    public int UserId { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public int StatusId { get; set; }
    public string Status { get; set; }
    public int CourseId { get; set; }
    public string Course { get; set; }
    public DateTime Startdate { get; set; }
    public int DurationInWeeks { get; set; }
    public DateTime Enddate { get; set; }
    public CourseDurationOfCurrentStudentDTO()
    {

    }
    public CourseDurationOfCurrentStudentDTO(int userId, string firstname, string lastname, int statusId, string status, int courseId, string course, DateTime startdate, int duration, DateTime enddate)
    {
        UserId = userId;
        Firstname = firstname;
        Lastname = lastname;
        StatusId = statusId;
        Status = status;
        CourseId = courseId;
        Course = course;
        Startdate = startdate;
        DurationInWeeks = duration;
        Enddate = enddate;
    }
    }
}

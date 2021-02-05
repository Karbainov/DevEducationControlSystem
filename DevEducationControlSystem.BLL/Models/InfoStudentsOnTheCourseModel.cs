using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class InfoStudentsOnTheCourseModel
    {
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string GroupName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public InfoStudentsOnTheCourseModel()
        {

        }

        public InfoStudentsOnTheCourseModel(InfoStudentsOnTheCourseDTO dto)
        {
            UserId = dto.UserId;
            GroupId = dto.GroupId;
            CourseId = dto.CourseId;
            CourseName = dto.CourseName;
            GroupName = dto.GroupName;
            FirstName = dto.FirstName;
            LastName = dto.LastName;
        }
    }
}

using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class NumberOfUsersByStatusInCourseModel
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public List<NumberOfUsersByStatusModel> NumberOfUsersByStatus { get; set; }

        public NumberOfUsersByStatusInCourseModel()
        {

        }
        public NumberOfUsersByStatusInCourseModel(NumberOfUsersByStatusInCourseDTO dto)
        {
            CourseId = dto.CourseId;
            CourseName = dto.CourseName;
            NumberOfUsersByStatus = new List<NumberOfUsersByStatusModel>();
            dto.NumberOfUsersByStatus.ForEach((r) =>
            {
                NumberOfUsersByStatus.Add(r != null ? new NumberOfUsersByStatusModel(r) : null);
            }
            );
        }
    }
}

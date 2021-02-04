using System;
using DevEducationControlSystem.DBL.DTO;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class CountStudentsOnCourseByGroupModel
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int CountOfStudents { get; set; }

        public CountStudentsOnCourseByGroupModel()
        {
        }

        public CountStudentsOnCourseByGroupModel(CountStudentsOnCourseByGroupsDTO dto)
        {
            GroupId = dto.Id;
            GroupName = dto.Name;
            CountOfStudents = dto.CountOfStudentsInGroup;

        }
    }
        
}

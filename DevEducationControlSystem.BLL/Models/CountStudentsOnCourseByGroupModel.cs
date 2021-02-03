using System;
using DevEducationControlSystem.DBL.DTO;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    class CountStudentsOnCourseByGroupModel
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int CountOfStudents { get; set; }

        public CountStudentsOnCourseByGroupModel()
        {
        }

        public CountStudentsOnCourseByGroupModel(CountStudentsOnCourseByGroupsDTO dto)
        {
            GroupId = dto.GroupId;
            GroupName = dto.GroupName;
            CountOfStudents = dto.CountOfStudents;

        }
        
}

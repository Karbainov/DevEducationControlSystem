using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class CountStudentsOnCourseByGroupsDTO
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int CountOfStudents { get; set; }

        public CountStudentsOnCourseByGroupsDTO(int groupId, string groupName, int countOfStudents)
        {
            GroupId = groupId;
            GroupName = groupName;
            CountOfStudents = countOfStudents;

        }

        public CountStudentsOnCourseByGroupsDTO()
        {

        }




    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class CountsStudentsTeachersTutorsByGroupDTO
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int Student { get; set; }
        public int Teacher { get; set; }
        public int Tutor { get; set; }

        public CountsStudentsTeachersTutorsByGroupDTO(int groupId, string groupName, int student, int teacher, int tutor)
        {
            GroupId = groupId;
            GroupName = groupName;
            Student = student;
            Teacher = teacher;
            Tutor = tutor;

        }




    }
}

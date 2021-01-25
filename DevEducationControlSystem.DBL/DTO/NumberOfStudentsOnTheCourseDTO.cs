using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class NumberOfStudentsOnTheCourse
    {
        public int GroupId { get; set; }
        public int CourseId { get; set; }
        public int UserGroup { get; set; }


        public NumberOfStudentsOnTheCourse(int groupId, int courseId, int userGroup)
        {
            GroupId = groupId;
            CourseId = courseId;
            UserGroup = userGroup;
        }

    }
}




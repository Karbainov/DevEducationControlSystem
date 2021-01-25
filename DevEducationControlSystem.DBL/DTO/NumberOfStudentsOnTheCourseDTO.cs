using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class NumberOfStudentsOnTheCourseDTO
    {
        public int GroupId { get; set; }
        public int CourseId { get; set; }
        public int UserGroup { get; set; }


        public NumberOfStudentsOnTheCourseDTO(int groupId, int courseId, int userGroup)
        {
            GroupId = groupId;
            CourseId = courseId;
            UserGroup = userGroup;
        }

    }
}




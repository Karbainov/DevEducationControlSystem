﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class NumberOfStudentsOnTheCourseDTO
    {
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public int CourseId { get; set; }
        public string GroupName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        //public NumberOfStudentsOnTheCourseDTO(int groupId, int courseId, int userId)
        //{
        //    GroupId = groupId;
        //    CourseId = courseId;
        //    UserId = userId;
        //}

    }
}




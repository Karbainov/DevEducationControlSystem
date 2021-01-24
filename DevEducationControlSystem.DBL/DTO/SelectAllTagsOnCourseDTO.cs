using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class SelectAllTagsOnCourseDTO
    {
        public string CourseName { get; set; }
        public string TagName { get; set; }

        public SelectAllTagsOnCourseDTO()
        {

        }

        public SelectAllTagsOnCourseDTO(string courseName, string tagName)
        {
            CourseName = courseName;
            TagName = tagName;
        }
    }
}

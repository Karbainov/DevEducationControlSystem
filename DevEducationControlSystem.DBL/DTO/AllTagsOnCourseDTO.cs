using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class AllTagsOnCourseDTO
    {
        public string Course { get; set; }
        public int TagId { get; set; }
        public string TagName { get; set; }

        public AllTagsOnCourseDTO()
        {

        }

        public AllTagsOnCourseDTO(string course, int tagId, string tagName)
        {
            Course = course;
            TagId = tagId;
            TagName = tagName;
        }
    }
}

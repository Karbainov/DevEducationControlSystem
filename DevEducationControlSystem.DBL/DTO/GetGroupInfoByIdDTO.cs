using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class GetGroupInfoByIdDTO
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }

    }
}

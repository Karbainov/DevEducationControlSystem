using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class SelectGroupsOnCoursesInfoModel
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }

        public SelectGroupsOnCoursesInfoModel()
        {

        }

        public SelectGroupsOnCoursesInfoModel(SelectGroupsOnCoursesInfoDTO dto)
        {
            CourseId = dto.CourseId;
            CourseName = dto.CourseName;
            GroupId = dto.GroupId;
            GroupName = dto.GroupName;
            StatusId = dto.StatusId;
            StatusName = dto.StatusName;
            CityId = dto.CityId;
            CityName = dto.CityName;          
           
        }
    }
}

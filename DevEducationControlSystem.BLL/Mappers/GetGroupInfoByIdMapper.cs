using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.CRUD;
using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.DTO.Base;
using DevEducationControlSystem.DBL.DTO.WholeCourseFeedback;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevEducationControlSystem.BLL.Mappers
{
    public class GetGroupInfoByIdMapper
    {             
        public GetGroupInfoByIdModel Mapp(GetGroupInfoByIdDTO group)
        {
            GetGroupInfoByIdModel selectGroupsOnCoursesInfoModel = new GetGroupInfoByIdModel()
            {
                CourseId = group.CourseId,
                CourseName = group.CourseName,
                GroupId = group.GroupId,
                GroupName = group.GroupName,
                StatusId = group.StatusId,
                StatusName = group.StatusName,
                CityId = group.CityId,
                CityName = group.CityName,
            };
            return selectGroupsOnCoursesInfoModel;
        }     
       
    }
}

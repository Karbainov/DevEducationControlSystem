using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Mappers
{
    public class GroupDTOUsersDTOMaterialsDTOHomeworksDTOtoGroupInfoModelMapper
    {
        public GroupInfoModel Map(GroupWithCityAndStatusAndCourseDTO group , List<HomeworkAllInfoDTO> homeworksInfo)
        {
            GroupInfoModel groupInfoModel = new GroupInfoModel()
            {
                Id = group.Id,
                Name = group.Name,
                StartDate = group.StartDate,
                StatusId = group.StatusId,
                Status = group.Status,
                CityId = group.CityId,
                City = group.City,
                CourseId = group.CourseId,
                Course = group.Course,
                Homeworks = new List<HomeworkInfoModel>()
            };

           
            foreach(var r in homeworksInfo)
            {
                if (r != null)
                {
                    groupInfoModel.Homeworks.Add(new HomeworkInfoModel(r));
                }
            }

            return groupInfoModel;
        }
    }
}

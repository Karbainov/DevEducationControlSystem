using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.BLL.Mappers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL
{
    public class GroupLogicManager
    {
        public GroupInfoModel GetGroupInfoById(int groupId)
        {
            //public GroupWithCityAndStatusAndCourseDTO SelectGroupWithCityAndStatusAndCourseById(int groupId)


            var mapper = new GroupDTOUsersDTOMaterialsDTOHomeworksDTOtoGroupInfoModelMapper();
            return mapper.Map();
        }
    }
}

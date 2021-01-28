using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.BLL.Mappers;
using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.DBL.CRUD;

namespace DevEducationControlSystem.BLL
{
    public class GroupLogicManager
    {
        public GroupInfoModel GetGroupInfoById(int groupId)
        {
            var homeworkManager = new HomeworkManager();
            var groupManager = new GroupManager();
            var mapper = new GroupDTOUsersDTOMaterialsDTOHomeworksDTOtoGroupInfoModelMapper();

            return mapper.Map(
                groupManager.SelectGroupWithCityAndStatusAndCourseById(groupId),
                homeworkManager.SelectAllHomeworkByGroupId(groupId)
                );
        }

        public StudentUnlockedDataModel GetStudentUnlockedData(int userId)
        {
            throw new NotImplementedException();
        }
    }
}

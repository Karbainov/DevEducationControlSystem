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
            var materialManager = new MaterialManager();
            var mapper = new GroupDTOUsersDTOMaterialsDTOHomeworksDTOtoGroupInfoModelMapper();

            return mapper.Map(
                groupManager.SelectGroupWithCityAndStatusAndCourseById(groupId),
                homeworkManager.SelectAllHomeworkByGroupId(groupId),
                materialManager.SelectMaterialsInfoForGroup(groupId)
                );
        }

        public ListOfUnlockedMaterialsByTagModel GetStudentUnlockedData(int userId)
        {
            throw new NotImplementedException();
        }

        public ListOfUnlockedMaterialsByTagModel GetStudentUnlockedMaterialsByTag(int userId, string tag)
        {
            var materialManager = new MaterialManager();
            var mapper = new UnlockedMaterialsWithTagsByUserIdAndTagDTOtoUnlockedMaterialsByTagModelMapper();
            return mapper.Map(materialManager.GetUnlockedMaterialsWithTagsByUserIdAndTag(userId, tag));
        }

        public ListRoleStatisticModel GetRoleStatistic()
        {
            var roleManager = new RoleManager();
            var mapper = new RoleStatisticMapper();
            return mapper.Map(roleManager.GetNumberOfPeoplePerRole());
        }
    }
}

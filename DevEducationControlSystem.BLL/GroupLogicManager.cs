using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.BLL.Mappers;
using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.DBL.CRUD;
using DevEducationControlSystem.DBL;

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

        public GroupAttendanceModel GetGroupAttendanceById(int groupId)
        {
            var statisticManager = new StatisticManager();
            var lessonManager = new LessonManager();
            var mapper = new UserPercentOfPresentDTOsLessonAttendanceDTOsToGroupAttendanceMapper();

            statisticManager.SelectPercentOfPresentsByGroupId(groupId);
            lessonManager.SelectLessonAttendanceByGroupId(groupId);

            return mapper.Map(statisticManager.SelectPercentOfPresentsByGroupId(groupId),
                                lessonManager.SelectLessonAttendanceByGroupId(groupId));
        }

        public void AddLessonWithAttendances(LessonModel lesson)
        {
            int lessonId = new LessonManager().Add(lesson.GroupId,lesson.Name,lesson.LessonDate,lesson.Comments);
            var users = new UserManager().SelectUsersByGroupId(lesson.GroupId);
            var manager = new AttendanceManager();
            users.ForEach((u) =>
            {
                manager.Add(u.Id, lessonId, false);
            });
        }

        public void UpdateAttendance(int attendanceId, bool isPresent)
        {
            var manager =  new AttendanceManager();
            manager.UpdateIsPresent(attendanceId, isPresent);
        }
    }
}

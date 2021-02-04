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

        public ListOfUnlockedMaterialsByTagModel GetStudentUnlockedMaterialsByTag(int userId, string tag)
        {
            var materialManager = new MaterialManager();
            var mapper = new UnlockedMaterialsWithTagsByUserIdAndTagDTOtoUnlockedMaterialsByTagModelMapper();
            return mapper.Map(materialManager.GetUnlockedMaterialsWithTagsByUserIdAndTag(userId, tag));
        }

        public GroupAttendanceModel GetGroupAttendanceById(string login, int groupId)
        {            var groupManager = new GroupManager();
            var group = groupManager.SelectById(groupId);
            if (group == null)
            {
                throw new ArgumentException("Group is not exist");
            }                        if (!isInGroup(login,groupId))
            {
                throw new UnauthorizedAccessException("Teacher is not in this group");
            }
            var statisticManager = new StatisticManager();
            var lessonManager = new LessonManager();
            var mapper = new UserPercentOfPresentDTOsLessonAttendanceDTOsToGroupAttendanceMapper();
            statisticManager.SelectPercentOfPresentsByGroupId(groupId);
            lessonManager.SelectLessonAttendanceByGroupId(groupId);

            return mapper.Map(statisticManager.SelectPercentOfPresentsByGroupId(groupId),
                                lessonManager.SelectLessonAttendanceByGroupId(groupId));
        }

        public PrivateStudentMainPageModel GetPrivateStudentMainPageModel(int studentId)
        {
            var courseManager = new CourseManager();
            var lessonManager = new LessonManager();

            var mapper = new CourseOverlookDTOGroupmatesDTOPassedLessonByStudentIdDTOtoPrivateStudentMainPageModelMapper();

            var privatePage = new PrivateStudentMainPageModel();

            privatePage = mapper.Map(
                courseManager.SelectCourseGeneralInfoByStudentId(studentId),
                lessonManager.SelectPassedLessonByStudentId(studentId));

            return privatePage;
        }

        public int AddAttendance(int userId, int lessonId, bool isPresent)
        {
            return new AttendanceManager().Add(userId, lessonId, isPresent);
        }

        public int AddLessonWithAttendances(string login, LessonModel lesson)
        {
            var groupManager = new GroupManager();
            var group = groupManager.SelectById(lesson.GroupId);
            if(group == null)
            {
                throw new ArgumentException("Group is not exist");
            }            if (!isInGroup(login, lesson.GroupId))
            {
                throw new UnauthorizedAccessException("Teacher is not in this group");
            }
            int lessonId = new LessonManager().Add(lesson.GroupId, lesson.Name, lesson.LessonDate, lesson.Comments);
            var users = new UserManager().SelectUsersByGroupId(lesson.GroupId);
            var manager = new AttendanceManager();
            users.ForEach((u) =>
            {
                if (u.StatusId == Parameters.BaseStudentStatusId || u.StatusId == Parameters.SpecialtyStudentStatusId)
                {
                    manager.Add(u.Id, lessonId, false);
                }
            });

            return lessonId;
        }

        public void UpdateAttendance(int attendanceId, bool isPresent)
        {
            var manager = new AttendanceManager();
            manager.UpdateIsPresent(attendanceId, isPresent);
        }
        public List<FeedbackModel> GetFeedbackByUserId(int userId)
        {
            var feedbackManager = new FeedbackManager();

            var mapper = new FeedbackDTOtoFeedbackModelMapper();

            return mapper.Map(feedbackManager.SelectByUserId(userId));
        }        private bool isInGroup(string login, int groupId)
        {
            var executor = new UserManager().GetLoginPassRole(login);            var userGroupsForExecutor = new User_GroupManager().SelectByUserId(executor.UserId);            bool isInGroup = false;            userGroupsForExecutor.ForEach((u) =>
            {
                if (u.GroupId == groupId)
                {
                    isInGroup = true;
                }
            });
            return isInGroup;
        }
    }
}

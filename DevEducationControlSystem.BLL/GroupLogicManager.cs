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
            var userManager = new UserManager();
            var mapper = new GroupDTOUsersDTOMaterialsDTOHomeworksDTOtoGroupInfoModelMapper();

            return mapper.Map(
                groupManager.SelectGroupWithCityAndStatusAndCourseById(groupId),
                homeworkManager.SelectAllHomeworkByGroupId(groupId),
                materialManager.SelectMaterialsInfoForGroup(groupId),
                userManager.SelectUsersByGroupId(groupId)
                );
        }



        public ListOfUnlockedMaterialsByTagModel GetStudentUnlockedMaterialsByTag(int userId, string tag)

        {

            var materialManager = new MaterialManager();

            var mapper = new UnlockedMaterialsWithTagsByUserIdAndTagDTOtoUnlockedMaterialsByTagModelMapper();

            return mapper.Map(materialManager.GetUnlockedMaterialsWithTagsByUserIdAndTag(userId, tag));

        }



        public GroupAttendanceModel GetGroupAttendanceById(string login, int groupId)
        {
            var groupManager = new GroupManager();
            var group = groupManager.SelectById(groupId);
            if (group == null)
            {
                throw new ArgumentException("Group is not exist");
            }
            
            if (!isInGroup(login,groupId))
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



        public StudentPrivateModel GetPrivateStudentMainPageModel(int studentId)
        {
            var courseManager = new CourseManager();
            var lessonManager = new LessonManager();
            var materialManager = new MaterialManager();
            var feedbackManager = new FeedbackManager();
            var feedbackMapper = new FeedbackDTOtoFeedbackModelMapper();
            var baseInfoMapper = new CourseOverlookDTOGroupmatesDTOPassedLessonByStudentIdDTOtoPrivateStudentMainPageModelMapper();
            var materialDTOs = materialManager.SelectUnlockedMaterialByUserIdDTOs(studentId);
            var materialModels = new List<UnlockedMaterialByUserIdModel>();
            
            foreach (var m in materialDTOs)
            {
                materialModels.Add(new UnlockedMaterialByUserIdModel()
                {
                    MaterialId = m.MaterialId,
                    LessonId = m.LessonId,
                    ResourceId= m.ResourceId,
                    MaterialName=m.MaterialName,
                    Message=m.Message,
                    Links =m.Links,
                    Images =m.Images,
                    MaterialThemeId = m.MaterialThemeId,
                    MaterialThemeName = m.MaterialThemeName
                });
            }

            var baseInfo = baseInfoMapper.Map(
                courseManager.SelectCourseGeneralInfoByStudentId(studentId),
                lessonManager.SelectPassedLessonByStudentId(studentId));

            var feedbackList = feedbackMapper.Map(feedbackManager.SelectByUserId(studentId));

            var hwDTOs = new HomeworkManager().SelectHomeWorksAndAnswersByUserId(studentId);
            var hwModels = new List<HomeworkWithAnswerModel>();

            foreach(var hw in hwDTOs)
            {
                hwModels.Add(new HomeworkWithAnswerModel()
                {
                    HomeworkId = hw.HomeworkId,
                    AnswerId = hw.AnswerId,
                    HWResourceId =hw.HWResourceId,
                    HWName = hw.HWName,
                    HWDescript = hw.HWDescript,
                    AnswerResourceId = hw.AnswerResourceId,
                    AnswerMessage = hw.AnswerMessage,
                    AnswerStatus =hw.AnswerStatus
                });
            }

            var mainMapper = new PrivateStudentMainPageModelFeedbackModelHomeworkWithAnswerModelMaterialModelToStudentPrivateModelMapper();
            return mainMapper.Map(baseInfo, feedbackList, materialModels,hwModels) ;

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
            }

            if (!isInGroup(login, lesson.GroupId))
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
                    manager.Add(u.UserId, lessonId, false);
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

        }

        private bool isInGroup(string login, int groupId)
        {
            var executor = new UserManager().GetLoginPassRole(login);

            var userGroupsForExecutor = new User_GroupManager().SelectByUserId(executor.UserId);
            bool isInGroup = false;
            userGroupsForExecutor.ForEach((u) =>
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

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

    public PrivateStudentMainPageModel GetPrivateStudentMainPageModel(int studentId)
    {
      var courseManager = new CourseManager();
      var lessonManager = new LessonManager();

      var mapper = new CourseOverlookDTOGroupmatesDTOPassedLessonByStudentIdDTOtoPrivateStudentMainPageModelMapper();

      var privatePage = new PrivateStudentMainPageModel();

            return privatePage;
        }

        public int AddAttendance(int userId, int lessonId, bool isPresent)
        {
            return new AttendanceManager().Add(userId, lessonId, isPresent);
        }

        public int AddLessonWithAttendances(LessonModel lesson)
        {
            var groupManager = new GroupManager();
            var group = groupManager.SelectById(lesson.GroupId);
            if(group == null)
            {
                throw new ArgumentException("Group is not exist");
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
        }
    public List<StudentModel> GetStudentsByGroupId(int groupId)
    {
      var groupManager = new GroupManager();
      var students = groupManager.SelectStudentsByGroupId(groupId);
      return mapper.Map(students);
      var mapper = new StudentDTOGroupDTOtoStudentsByGroupIdMapper();
    }
    public List<PassedThemesAndHomeworksAndAnswerModel> GetPassedThemesAndHomeworksAndAnswerModelByGroupId(int studentId)

    {
      var groupManager = new GroupManager();
      var ThemesHomeworksAnswer = groupManager.SelectPassedThemesAndHomeworksAndAnswerByStudentId(studentId);
      var mapper = new HomeworkDTOThemeDTOAnswerDTOtoPassedHomeworkThemeAnswerByStudentIdMapper();
      return mapper.Map(ThemesHomeworksAnswer);
    }
    public List<StudentAnswerStoryAndCommentModel> GetStudentAnswerStoryAndCommentById(int userid, int homeworkId)
    {
      var commentManager = new CommentManager();
      var answerManager = new AnswerManager();
      var answer = answerManager.SelectAnswerByUserIdAndHomeworkId(userid, homeworkId);
      var homeworkManager = new HomeworkManager();
      var mapper = new UserDTOHomeworkDTOAnswerDTOCommentDTOtoStudentAnswerStoryAndCommentMapper();
      return mapper.Map(commentManager.SelectСommentByAnswerIdOrderByTime(answer.AnswerId), homeworkManager.SelectById(homeworkId), answer);
    
    }
  }
}

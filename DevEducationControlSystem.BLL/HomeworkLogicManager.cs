using DevEducationControlSystem.BLL.Mappers;
using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.CRUD;
using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL
{
    public class HomeworkLogicManager
    {
        public void AppointHomeworkToGroup(HomeworkAppointmentModel homeworkAppointmentModel)
        {
            var groupManager = new GroupManager();
            var group = groupManager.SelectById(homeworkAppointmentModel.GroupId);
            if (group == null)
            {
                throw new ArgumentException("Group is not exist");
            }

            var homeworkManager = new HomeworkManager();
            var homework = homeworkManager.SelectById(homeworkAppointmentModel.HomeworkId);
            if(homework == null)
            {
                throw new ArgumentException("Homework is not exist");
            }

            var ghManager = new Group_HomeworkManager();
            ghManager.Add(homeworkAppointmentModel.GroupId,
                homeworkAppointmentModel.HomeworkId,
                homeworkAppointmentModel.StartDate,
                homeworkAppointmentModel.DeadLine);

            var users = new UserManager().SelectUsersByGroupId(homeworkAppointmentModel.GroupId);
            var answerManager = new AnswerManager();
            users.ForEach((u) =>
            {
                if (u.StatusId == Parameters.BaseStudentStatusId || u.StatusId == Parameters.SpecialtyStudentStatusId)
                {
                    answerManager.Add(u.Id,
                        null,
                        homeworkAppointmentModel.HomeworkId,
                        homeworkAppointmentModel.StartDate,
                        null,
                        Parameters.AppointedAnswerStatus);
                }
            });
        }

        public List<AnswerExpandedDTO> SelectAllAnswersByHomeworkIdAndGroupId(int homeworkId, int groupId)
        {
            var groupManager = new GroupManager();
            var group = groupManager.SelectById(groupId);
            if (group == null)
            {
                throw new ArgumentException("Group is not exist");
            }

            var homeworkManager = new HomeworkManager();
            var homework = homeworkManager.SelectById(homeworkId);
            if (homework == null)
            {
                throw new ArgumentException("Homework is not exist");
            }
            return new AnswerManager().SelectAllAnswersByHomeworkIdAndGroupId(homeworkId, groupId);
        }
        public List<StudentModel> GetStudentsByGroupId(int groupId)
        {
          var groupManager = new GroupManager();
          var students = groupManager.SelectStudentsByGroupId(groupId);
          var mapper = new StudentDTOGroupDTOtoStudentsByGroupIdMapper();
          return mapper.Map(students);
        }
        
        public List<PassedThemesAndHomeworksAndAnswerModel> GetPassedThemesAndHomeworksAndAnswerModelByGroupId(int studentId)
        {
          var groupManager = new GroupManager();
          var ThemesHomeworksAnswer = groupManager.SelectPassedThemesAndHomeworksAndAnswerByStudentId(studentId);
          var mapper = new HomeworkDTOThemeDTOAnswerDTOtoPassedHomeworkThemeAnswerByStudentIdMapper();
          return mapper.Map(ThemesHomeworksAnswer);
        }
        public StudentAnswerModel GetStudentAnswerStoryAndCommentById(int answerId)
        {
          var commentManager = new CommentManager();
          var answerManager = new AnswerManager();
          var mapper = new UserDTOHomeworkDTOAnswerDTOCommentDTOtoStudentAnswerStoryAndCommentMapper();
          return mapper.Map(commentManager.SelectСommentByAnswerIdOrderByTime(answerId), answerManager.SelectAnswerAndStatusAnswerById(answerId));
        }
    }
}

using DevEducationControlSystem.BLL.Mappers;
using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL
{
    public class StatisticLogicManager
    {
        public ListOfTeachersByCourseModel GetNumberOfTeachers()
        {
            var statisticManager = new StatisticManager();
            var mapper = new NumberOfTeachersByCourseDTOtoNumberOfTeachersByCourseModelMapper();

            return mapper.Map(statisticManager.SelectNumberOfTeachersByCourse());
        }

        public ListOfCountOfStudentsOnCourseByGroupsModel NumberOfStudentsOnCourseByGroups(int CourseId)
        { 
            var statisticManager = new StatisticManager();
            var mapper = new CountStudentsOnCourseByGroupsDTOtoCountStudentsOnCourseByGroupModel();

            return mapper.Map(statisticManager.GetCountStudentsOnCourseByGroups(CourseId));
         
        }
    }
}

using DevEducationControlSystem.BLL.Mappers;
using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL;
using DevEducationControlSystem.DBL.CRUD;
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

        //public List<NumberOfTeachersByCourseModel> GetNumberOfTeachersStat()
        //{
        //    var statisticManager = new StatisticManager();
        //    var mapper = new NumberOfTeachersByCourseDTOtoNumberOfTeachersByCourseModelSecondMapper();

        //    return mapper.Map(statisticManager.SelectNumberOfTeachersByCourse());
        //}

        public NumberOfTeachersByCourseModel GetNumberOfTeachersByCourseId(int id)
        {
            var statisticManager = new StatisticManager();
            var mapper = new NumberOfTeachersByCourseDTOtoNumberOfTeachersByCourseModelSecondMapper();
            return mapper.Map(statisticManager.SelectNumberOfTeachersByCourseId(id),
                statisticManager.SelectTeachersOnCourseStatisctic());
        }

        public List<RoleStatisticModel> GetRoleStatistic()
        {
            var roleManager = new RoleManager();
            var mapper = new RoleStatisticMapper();
            return mapper.Map(roleManager.GetNumberOfPeoplePerRole());
        }
    }
}
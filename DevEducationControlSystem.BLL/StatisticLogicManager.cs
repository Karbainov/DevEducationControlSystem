using DevEducationControlSystem.BLL.Mappers;
using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL;
using DevEducationControlSystem.DBL.DTO;
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

        

        //public NumberOfTeachersByCourseModel GetNumberOfTeachersByCourseId(int id)
        //{
        //    var statisticManager = new StatisticManager();
        //    var mapper = new NumberOfTeachersByCourseDTOtoNumberOfTeachersByCourseModelSecondMapper();
        //    return mapper.Map(statisticManager.SelectNumberOfTeachersByCourseId(id),
        //        statisticManager.SelectTeachersOnCourseStatisctic());
        //}

        public NumberOfTeachersByCourseModel GetNumberOfTeachersByCourseId(int id)
        {
            var statisticManager = new StatisticManager();
            var mapper = new NumberOfTeachersByCourseDTOtoNumberOfTeachersByCourseModelSecondMapper();
            return mapper.Map(statisticManager.SelectNumberOfTeachersByCourseId(id),
                statisticManager.SelectTeachersOnCourseStatisctic());
        }


        public List<NumberOfUsersWithStatusInCourseInCityDTO> GetNumberOfUsersWithStatusInCourseInCity()
        {
            var statisticManager = new StatisticManager();

            var mapper = new NumberOfUsersWithStatusInCourseInCityDTOMapper();
            return statisticManager.SelectNumberOfUsersWithStatusInCourseInCity();
        }
        public List<RoleStatisticModel> GetRoleStatistic()
        {
            var roleManager = new RoleManager();
            var mapper = new RoleStatisticMapper();
            return mapper.Map(roleManager.GetNumberOfPeoplePerRole());
        }

        public ListOfCountOfStudentsOnCourseByGroupsModel NumberOfStudentsOnCourseByGroups(int CourseId)
        { 
            var statisticManager = new StatisticManager();
            var mapper = new CountStudentsOnCourseByGroupsDTOtoCountStudentsOnCourseByGroupModel();

            return mapper.Map(statisticManager.GetCountStudentsOnCourseByGroups(CourseId));
         
        }
    }
}
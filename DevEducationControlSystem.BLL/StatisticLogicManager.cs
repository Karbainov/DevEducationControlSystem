using DevEducationControlSystem.BLL.Mappers;
using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL;
using DevEducationControlSystem.DBL.DTO;
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

        public List<NumberOfUsersWithStatusInCourseInCityDTO> GetNumberOfUsersWithStatusInCourseInCity()
        {
            //public List<NumberOfUsersWithStatusInGroupInCityDTO> SelectNumberOfUsersWithStatusInGroupInCity()
            var statisticManager = new StatisticManager();

            var mapper = new NumberOfUsersWithStatusInCourseInCityDTOMapper();
            return statisticManager.SelectNumberOfUsersWithStatusInCourseInCity();
        }
    }
}

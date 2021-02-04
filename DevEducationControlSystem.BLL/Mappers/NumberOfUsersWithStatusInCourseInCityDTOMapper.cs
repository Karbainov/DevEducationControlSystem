using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL;
using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Mappers
{
    public class NumberOfUsersWithStatusInCourseInCityDTOMapper
    {
        public NumberOfUsersWithStatusInCourseInCityModel Map(List<NumberOfUsersWithStatusInCourseInCityDTO> userStatusInCityInfo)
        {


            //var numberOfUsersWithStatusInCourseInCity = new NumberOfUsersWithStatusInCourseInCityModel();

            //var numberOfUsersByStatusInCourse = new List<NumberOfUsersByStatusInCourseDTO>();
            //var numberOfUsersByStatus = new List<NumberOfUsersByStatusDTO>();
            //numberOfUsersWithStatusInCourseInCity.NumberOfUsersByStatusInCourse = new List<NumberOfUsersByStatusInCourseModel>();
            //numberOfUsersByStatusInCourse.ForEach((r) =>
            //{
            //    numberOfUsersWithStatusInCourseInCity.NumberOfUsersByStatusInCourse.Add(new NumberOfUsersByStatusInCourseModel(r));
            //});
            //numberOfUsersByStatus.ForEach((r) =>
            //{
            //    numberOfUsersByStatusInCourse.NumberOfUsersByStatus.Add(new NumberOfUsersByStatusModel(r));
            //});
            return null;
        }
        //List<NumberOfUsersWithStatusInCourseInCityDTO>

        //public GroupAttendanceModel Map(List<UserPercentOfPresentsDTO> userPercents, List<LessonAttendanceDTO> lessonAttendances)
        //{
        //    var groupAttendance = new GroupAttendanceModel();
        //    groupAttendance.UsersPercentOfPresent = userPercents;
        //    groupAttendance.LessonsAttendances = new List<LessonAttendanceModel>();
        //    lessonAttendances.ForEach((r) => { groupAttendance.LessonsAttendances.Add(new LessonAttendanceModel(r)); });
        //    return groupAttendance;
        //}
    }
}

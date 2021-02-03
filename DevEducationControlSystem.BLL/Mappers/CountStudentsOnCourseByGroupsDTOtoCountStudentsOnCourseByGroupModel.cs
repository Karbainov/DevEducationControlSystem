using System;
using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.DTO;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Mappers
{
    class CountStudentsOnCourseByGroupsDTOtoCountStudentsOnCourseByGroupModel
    {
        public ListOfCountOfStudentsOnCourseByGroupsModel Map(List<CountStudentsOnCourseByGroupsDTO> countStudentsOnCourseByGroups)
        {
            var listOfStudentsOnCourseByGroup = new ListOfCountOfStudentsOnCourseByGroupsModel(){ studentsOnCourseByGroupsList = new List<CountStudentsOnCourseByGroupModel>() };


            foreach (var n in countStudentsOnCourseByGroups)
            {
                listOfStudentsOnCourseByGroup.studentsOnCourseByGroupsList.Add(new CountStudentsOnCourseByGroupModel(n));
            }
            return listOfStudentsOnCourseByGroup;
        }

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

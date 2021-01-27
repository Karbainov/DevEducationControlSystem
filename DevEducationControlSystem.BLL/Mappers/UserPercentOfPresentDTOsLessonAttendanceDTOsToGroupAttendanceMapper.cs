using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Mappers
{
    public class UserPercentOfPresentDTOsLessonAttendanceDTOsToGroupAttendanceMapper
    {
        public GroupAttendanceModel Map(List<UserPercentOfPresentsDTO> userPercents, List<LessonAttendanceDTO> lessonAttendances)
        {
            var groupAttendance = new GroupAttendanceModel();
            groupAttendance.UsersPercentOfPresent = userPercents;
            groupAttendance.LessonsAttendances = lessonAttendances;
            return groupAttendance;
        }
    }
}

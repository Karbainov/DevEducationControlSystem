using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class GroupAttendanceModel
    {
        public List<UserPercentOfPresentsDTO> UsersPercentOfPresent { get; set; }
        public List<LessonAttendanceModel> LessonsAttendances { get; set; }
    }
}

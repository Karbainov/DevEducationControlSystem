using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class CourseGeneralInfoModel
    {
        public int CourseId;
        public string CourseName;
        public DateTime CourseStartDate;
        public int DurationInWeeks;
        public int GroupId;
        public string GroupName;
        public int TeacherId;
        public string TeacherFirstName;
        public string TeacherLastName;
        public int TutorId;
        public string TutorFirstName;
        public string TutorLastName;
        public List<StudentPublicInfoModel> StudentPublicInfoModels;
        public List<PassedLessonByStudentIdModel> passedLessonByStudentIdModels;

        
    }
}

using System;
using System.Collections.Generic;
using System.Text;


namespace DevEducationControlSystem.DBL.DTO
{
    public class CourseGeneralInfoByStudentIdDTO
    {
        public int CourseId;
        public string CourseName;
        public DateTime CourseStartDate;
        public int DurationInWeeks;
        public int GroupId;
        public int GroupName;
        public int TeacherId;
        public string TeacherFirstName;
        public string TeacherLastName;
        public int TutorId;
        public string TutorFirstName;
        public string TutorLastName;
        public List<int> StudentId;
        public List<string> StudenFirstName;
        public List<string> StudenLasttName;  
    }
}

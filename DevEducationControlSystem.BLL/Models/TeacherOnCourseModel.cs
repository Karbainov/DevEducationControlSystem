using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class TeacherOnCourseModel
    {
        public int CourseId { get; set; }
        public int GroupId {get; set;}
        public string GroupName {get; set;}
        public int TeacherId {get; set;}
        public string TeacherName {get; set;}
        //public int AmountOfGroups {get; set;}
        //public int AmountOfStudents {get; set;}
        //public int AmountOfStudentsFinished { get; set;}
        //public int AverageRateAllTime {get; set;}
        //public int AverageRateCurrGroup { get; set;}

        public TeacherOnCourseModel()
        {

        }

        public TeacherOnCourseModel(TeacherOnCourseDTO dto)
        {
            CourseId = dto.CourseId;
            GroupId = dto.GroupId;
            GroupName = dto.GroupName;
            TeacherId = dto.TeacherId;
            TeacherName = dto.TeacherName;
            //AmountOfGroups = dto.AmountOfGroups 
            //AmountOfStudents = AmountOfStudents 
            //AmountOfStudentsFinished = AmountOfStudentsFinished 
            //AverageRateAllTime = AverageRateAllTime 
            //AverageRateCurrGroup = AverageRateCurrGroup
        }
    }
}

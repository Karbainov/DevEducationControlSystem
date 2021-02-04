using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class SelectAmountOfGroupsStudentsGradStudentsRateForTeachersDTO
    {
        public int CourseId { get; set; }
        public int GroupId {get; set;}
        public string GroupName {get; set;}
        public int TeacherId {get; set;}
        public string TeacherName {get; set;}
        public int AmountOfGroups {get; set;}
        public int AmountOfStudents {get; set;}
        public int AmountOfStudentsFinished {get; set;}
        public int AllTimeRate {get; set;}
        public int PostGradRate {get; set;}

        public SelectAmountOfGroupsStudentsGradStudentsRateForTeachersDTO()
        {

        }

        public SelectAmountOfGroupsStudentsGradStudentsRateForTeachersDTO(SelectAmountOfGroupsStudentsGradStudentsRateForTeachersDTO dto)
        {
            CourseId = dto.CourseId;
            GroupId = dto.GroupId;
            GroupName = dto.GroupName;
            TeacherId = dto.TeacherId;
            TeacherName = dto.TeacherName;
            AmountOfGroups = dto.AmountOfGroups;
            AmountOfStudents = dto.AmountOfStudents;
            AmountOfStudentsFinished = dto.AmountOfStudentsFinished;
            AllTimeRate = dto.AllTimeRate;
            PostGradRate = dto.PostGradRate;
        }
    }
}

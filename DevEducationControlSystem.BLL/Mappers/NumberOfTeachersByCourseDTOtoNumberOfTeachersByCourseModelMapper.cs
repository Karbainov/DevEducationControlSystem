using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Mappers
{
    public class NumberOfTeachersByCourseDTOtoNumberOfTeachersByCourseModelMapper
    {
        public ListOfTeachersByCourseModel Map(List<NumberOfTeachersByCourseDTO> numberOfTeachers)
        {
            var listOfTeachers = new ListOfTeachersByCourseModel() { 
                teachersByCourseList = new List<NumberOfTeachersByCourseModel>(),
                
            };


            foreach (var n in numberOfTeachers)
            {
                listOfTeachers.teachersByCourseList.Add(new NumberOfTeachersByCourseModel(n));
            }
            return listOfTeachers;
        }
    }
}

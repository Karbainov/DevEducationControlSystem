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
            var listOfTeachers = new ListOfTeachersByCourseModel();

            foreach(var n in numberOfTeachers)
            {
                if (n != null)
                {
                    listOfTeachers.teachersByCourseList.Add(new NumberOfTeachersByCourseModel(n));
                }
            }
            return listOfTeachers;
        }

        //public ListOfTeachersByCourseModel Map(List<NumberOfTeachersByCourseModel> numberOfTeachersList)
        //{
        //    ListOfTeachersByCourseModel numberOfTeachers = new ListOfTeachersByCourseModel()
        //    {

        //    };
        //    foreach (var r in numberOfTeachersList)
        //    {
        //        if (r != null)
        //        {
        //            numberOfTeachers.teachersByCourseList.Add(new NumberOfTeachersByCourseModel(r));
        //        }
        //    }

        //var numberOfTeachersModel = new NumberOfTeachersByCourseModel()
        //{
        //    CourseId = numberOfTeachers.CourseId,
        //    CourseName = numberOfTeachers.CourseName,
        //    CityId = numberOfTeachers.CityId,
        //    CityName = numberOfTeachers.CityName,
        //    Amount = numberOfTeachers.Amount
        //};


    
    }
}

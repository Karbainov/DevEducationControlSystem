using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Mappers
{
    public class NumberOfTeachersByCourseDTOtoNumberOfTeachersByCourseModelSecondMapper
    {
        public NumberOfTeachersByCourseModel Map(
            //List<NumberOfTeachersByCourseDTO> dtoList,
            NumberOfTeachersByCourseIdDTO dto,
            List<TeacherOnCourseDTO> teacherOnCourses
            )
        {
            var listOfTeachers = new NumberOfTeachersByCourseModel();


            var numberModel = new NumberOfTeachersByCourseModel()
            {
                CourseId = dto.CourseId,
                CourseName = dto.CourseName,
                CityId = dto.CityId,
                CityName = dto.CityName,
                Amount = dto.Amount,
                Teachers = new List<TeacherOnCourseModel>()
            };
            
            foreach (var n in teacherOnCourses)
            {
                numberModel.Teachers.Add(new TeacherOnCourseModel(n));
            }


            //foreach (var r in dtoList)
            //{
            //    listOfTeachers.Add(numberModel(r));
            //}

            return listOfTeachers;
        }





    }
}

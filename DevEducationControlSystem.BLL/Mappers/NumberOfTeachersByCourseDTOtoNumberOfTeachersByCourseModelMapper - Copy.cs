using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Mappers
{
    public class NumberOfTeachersByCourseDTOtoNumberOfTeachersByCourseModelSecondMapper
    {
        public List<NumberOfTeachersByCourseModel> Map(
            //List<NumberOfTeachersByCourseDTO> dtoList,
            NumberOfTeachersByCourseDTO dto,
            List<TeacherOnCourseDTO> teacherOnCourses
            )
        {
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

            var listOfTeachers = new List<NumberOfTeachersByCourseModel>();

            //foreach (var r in dtoList)
            //{
            //    listOfTeachers.Add(numberModel(r));
            //}

            return listOfTeachers;
        }





    }
}

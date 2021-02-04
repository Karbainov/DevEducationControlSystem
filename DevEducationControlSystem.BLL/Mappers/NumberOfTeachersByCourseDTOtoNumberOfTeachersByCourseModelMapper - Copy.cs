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
            NumberOfTeachersByCourseIdDTO dto,
            List<SelectAmountOfGroupsStudentsGradStudentsRateForTeachersDTO> teacherOnCourses
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
                TeachersStat = new List<SelectAmountOfGroupsStudentsGradStudentsRateForTeachersModel>()
            };
            
            foreach (var n in teacherOnCourses)
            {
                numberModel.TeachersStat.Add(new SelectAmountOfGroupsStudentsGradStudentsRateForTeachersModel(n));
            }


            //foreach (var r in dtoList)
            //{
            //    listOfTeachers.Add(numberModel(r));
            //}

            return listOfTeachers;
        }





    }
}

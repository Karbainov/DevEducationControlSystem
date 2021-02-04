using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Mappers
{
    public class NumberOfTeachersByCourseDTOtoNumberOfTeachersByCourseModelMapper
    {
        public ListOfTeachersByCourseModel Map(

            List<NumberOfTeachersByCourseDTO> dto
            ,List<SelectAmountOfGroupsStudentsGradStudentsRateForTeachersDTO> teacherOnCourses
            )
        {
            var model = new ListOfTeachersByCourseModel();
            model.teachersByCourseList = new List<NumberOfTeachersByCourseModel>();
            model.TeachersStat = new List<SelectAmountOfGroupsStudentsGradStudentsRateForTeachersModel>();


            foreach (var n in dto)
            {
                model.teachersByCourseList.Add(new NumberOfTeachersByCourseModel(n));
            }

            foreach (var s in teacherOnCourses)
            {
                model.TeachersStat.Add(new SelectAmountOfGroupsStudentsGradStudentsRateForTeachersModel(s));
            }

            return model;
        }





    }
}

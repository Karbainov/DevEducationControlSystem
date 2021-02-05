using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.CRUD;
using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.DTO.Base;
using DevEducationControlSystem.DBL.DTO.WholeCourseFeedback;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DevEducationControlSystem.BLL.Mappers
{
    public class InfoAboutUsersOnThecourseMapper
    {
        public ListOfAllInfoUserOnTheCourseModel Map(List<AllInfoUserOnTheCourseDTO> course, List<InfoStudentsOnTheCourseDTO> numberStudents)
        {
            ListOfAllInfoUserOnTheCourseModel allInfoUserOnTheCourseModel = new ListOfAllInfoUserOnTheCourseModel()
            {
                Course = new List<InfoStudentsOnTheCourseModel>(),
                Info = new List<AllInfoUserOnTheCourseModel>()
            };


            foreach (var r in course)
            {
                if (r != null)
                {
                    allInfoUserOnTheCourseModel.Info.Add(new AllInfoUserOnTheCourseModel(r));
                }
            }

            foreach (var r in numberStudents)
            {
                if (r != null)
                {
                    allInfoUserOnTheCourseModel.Course.Add(new InfoStudentsOnTheCourseModel(r));
                }
            }
            return allInfoUserOnTheCourseModel;
        }
    }
}

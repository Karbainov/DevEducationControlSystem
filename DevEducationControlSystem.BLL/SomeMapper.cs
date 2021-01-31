using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.CRUD;
using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.DTO.WholeCourseFeedback;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevEducationControlSystem.BLL.Mappers
{
    public class SomeMapper
    {
        public AllInfoUserOnTheCourseModel Map(List<AllInfoUserOnTheCourseDTO> course, List<NumberOfStudentsOnTheCourseDTO> numberStudents)
        {
            AllInfoUserOnTheCourseModel allInfoUserOnTheCourseModel = new AllInfoUserOnTheCourseModel()
            {
                //Id = course.Id,
                //StatusId = course.StatusId,
                //FirstName = course.FirstName,
                //LastName = course.LastName,
                //BirthDate = course.BirthDate,
                //Login = course.Login,
                //Password = course.Password,
                //email = course.email,
                //Phone = course.Phone,
                //ContractNumber = course.ContractNumber,
                //ProfileImage = course.ProfileImage,
                //Status = course.ProfileImage,
                //GroupName = course.GroupName,
                Course = new List<NumberOfStudentsOnTheCourseModel>(),
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
                if(r != null)
                {
                    allInfoUserOnTheCourseModel.Course.Add(new NumberOfStudentsOnTheCourseModel(r));
                }
            }


            return allInfoUserOnTheCourseModel;
        }

       
    }
}

using DevEducationControlSystem.BLL.Mappers;
using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.CRUD;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL
{
    public class AllInfoUserOnTheCourseLogicManager
    {
        public AllInfoUserOnTheCourseModel GetNumberOfStudentsOnTheCourseById(int courseId)
        {
            var numberOfStudentsOnTheCourseManager = new NumberOfStudentsOnTheCourseManager();
            var allInfoUserOnTheCourseManager = new AllInfoUserOnTheCourseManager();
            var mapper = new SomeMapper();
            return mapper.Map(
                allInfoUserOnTheCourseManager.AllInfoUserOnTheCourseById(courseId), 
                numberOfStudentsOnTheCourseManager.SelectCourseInfoById(courseId)
                );           
        }
    }
}

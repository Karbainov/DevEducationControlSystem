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
        public ListOfAllInfoUserOnTheCourseModel GetInfoOfStudentsOnTheCourseById(int courseId)
        {
            var numberOfStudentsOnTheCourseManager = new InfoStudentsOnTheCourseManager();
            var allInfoUserOnTheCourseManager = new AllInfoUserOnTheCourseManager();
            var mapper = new InfoAboutUsersOnThecourseMapper();
            return mapper.Map(
                allInfoUserOnTheCourseManager.SelectCourseInfoById(courseId), 
                numberOfStudentsOnTheCourseManager.SelectCourseInfoById(courseId)
                );           
        }

        public GetGroupInfoByIdModel GetGroupInfoById(int groupId)
        {
            var GroupManager = new GetGroupInfoByIdManager();
            var mapper = new GetGroupInfoByIdMapper();
            return mapper.Mapp(GroupManager.SelectGroupInfoById(groupId));
        }
    }
}

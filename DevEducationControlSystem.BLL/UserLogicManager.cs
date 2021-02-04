using DevEducationControlSystem.BLL.Mappers;
using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.CRUD;
using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL
{
    public class UserLogicManager
    {
        public List<HomeworkWithStatusModel> GetHomeworksWithStatus(int userId)
        {
            var homeworkManager = new HomeworkManager();
            var mapper = new HomeworkWithStatusMapper();
            return mapper.Map(homeworkManager.SelectHomeworkWithStatusesByUserId(userId));
        }
        public List<AllInfoOfUserDTO> GetAllUserInfo()
        {
            var userManager = new UserManager();
            return userManager.GetInfoOfAllUsers();
        }
        public AllInfoOfUserDTO GetAllUserInfoById(int userId)
        {
            var userManager = new UserManager();
            return userManager.GetAllInfoOfUserById(userId);
        }
    }
}

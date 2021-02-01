using DevEducationControlSystem.BLL.Mappers;
using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.CRUD;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL
{
    public class UserLogicManager
    {
        public HomeworkWithStatusModel GetHomeworksWithStatus(int userId)
        {
            var homeworkManager = new HomeworkManager();
            var mapper = new HomeworkWithStatusMapper();
            return mapper.Map(homeworkManager.SelectHomeworkWithStatusesByUserId(userId));
        }
    }
}

using AutoMapper;
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
        public List<HomeworkWithStatusModel> GetHomeworksWithStatus(int userId)
        {
            var homeworkManager = new HomeworkManager();
            var mapper = new HomeworkWithStatusMapper();
            return mapper.Map(homeworkManager.SelectHomeworkWithStatusesByUserId(userId));
        }

        public StudentPaymentInfoModel GetStudentPaymentInfo (int userId)
        {
            var userManager = new UserManager();
            var paymentManager = new PaymentManager();
            var mapper = new StudentPaymentInfoMapper();
            return mapper.Map(userManager.SelectById(userId), paymentManager.SelectPaymentInfo(userId));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevEducationControlSystem.API.InputModels;
using DevEducationControlSystem.DBL.DTO.Base;
using DevEducationControlSystem.DBL.CRUD;
using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.BLL;

namespace DevEducationControlSystem.API
{
    public class GroupAPIManager
    {
        public FeedbackModel AddAndCheckNewFeedback(NewFeedbackInputModel model, int userId)
        {
            var dalManager = new FeedbackManager();
            dalManager.Add(model.UserId, model.LessonId, model.Rate, model.Message);

            var bllManager = new GroupLogicManager();

            return bllManager.GetFeedbackByUserId(userId) ;
        }
    }
}

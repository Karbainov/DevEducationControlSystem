﻿using System;
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
        public void AddAndCheckNewFeedback(List<FeedbackInputModel> feedbackModelsList, int userId)
        {
            var dalManager = new FeedbackManager();

            foreach (var f in feedbackModelsList)
            {
                var pfDTO = dalManager.SelectFeedbackByUserIdAndLessonId(userId, f.LessonId);

                if (pfDTO!=null)
                {
                    
                    dalManager.Update(pfDTO.Id, f.UserId, f.LessonId, f.Rate, f.Message);
                }
                else
                {
                    dalManager.Add(f.UserId, f.LessonId, f.Rate, f.Message);
                }
            }

            var bllManager = new GroupLogicManager();

            return;
        }

        internal void DeleteAndCheckFeedback(List<FeedbackInputModel> feedbackModelsList, int userId)
        {
            var dalManager = new FeedbackManager();
            foreach (var f in feedbackModelsList)
            {
                if (f.Id != null) dalManager.Delete((int)f.Id);
            }
        }
    }
}

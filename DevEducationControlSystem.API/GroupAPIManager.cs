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
        public List<FeedbackModel> AddAndCheckNewFeedback(List<NewFeedbackInputModel> feedbackModelsList, int userId)
        {
            var dalManager = new FeedbackManager();
            List<FeedbackDTO> previousFeedbackDTOs = null;

            foreach (var f in feedbackModelsList)
            {
                var pfDTO = dalManager.SelectFeedbackByUserIdAndLessonId(userId, f.LessonId);

                if (pfDTO!=null)
                {
                    if (previousFeedbackDTOs == null)
                    {
                        previousFeedbackDTOs = new List<FeedbackDTO>();
                    }
                    previousFeedbackDTOs.Add(pfDTO);
                }
            }


            if (previousFeedbackDTOs != null)
            {
                foreach (var pfDTO in previousFeedbackDTOs)
                {
                    foreach (var f in feedbackModelsList)
                    {
                        if (pfDTO.LessonId == f.LessonId)
                        {
                            dalManager.Update(pfDTO.Id, f.UserId, f.LessonId, f.Rate, f.Message);
                        }
                        else
                        {
                            dalManager.Add(f.UserId, f.LessonId, f.Rate, f.Message);
                        }
                    }
                }
            }
            else
            {
                foreach (var f in feedbackModelsList)
                {
                    dalManager.Add(f.UserId, f.LessonId, f.Rate, f.Message);
                }
            }

            var bllManager = new GroupLogicManager();

            return bllManager.GetFeedbackByUserId(userId);
        }
    }
}

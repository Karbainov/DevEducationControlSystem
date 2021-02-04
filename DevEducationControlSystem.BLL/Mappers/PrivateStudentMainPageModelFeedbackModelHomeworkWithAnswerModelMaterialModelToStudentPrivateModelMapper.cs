using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.BLL.Models;

namespace DevEducationControlSystem.BLL.Mappers
{
    public class PrivateStudentMainPageModelFeedbackModelHomeworkWithAnswerModelMaterialModelToStudentPrivateModelMapper
    {
        public StudentPrivateModel Map(
            PrivateStudentMainPageModel overlook,
            List<FeedbackModel> feedback,
            List<UnlockedMaterialByUserIdModel> materials,
            List<HomeworkWithAnswerModel> hwWithAnswer)
        {

            return new StudentPrivateModel()
            {
                BaseInfo = overlook,
                Feedbacks = feedback,
                UnlockedMaterials = materials,
                HomeworksWithAnswers = hwWithAnswer
            };
        }
        }
}

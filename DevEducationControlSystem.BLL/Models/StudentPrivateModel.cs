using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class StudentPrivateModel
    {
        public PrivateStudentMainPageModel BaseInfo { get; set; }
        public List<HomeworkWithAnswerModel> HomeworksWithAnswers { get; set; }
        public List<FeedbackModel> Feedbacks { get; set; }
        public List<UnlockedMaterialByUserIdModel> UnlockedMaterials { get; set; }
    }
}

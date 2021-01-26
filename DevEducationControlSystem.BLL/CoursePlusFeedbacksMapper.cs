using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.CRUD;
using DevEducationControlSystem.DBL.DTO.WholeCourseFeedback;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevEducationControlSystem.BLL
{
    public class CoursePlusFeedbacksMapper
    {
        public CourseInfoAndFeedbacksModel GetCourseInfoAndFeedbacksByCourseId(int courseId)
        {
            FeedbackManager feedbackManager = new FeedbackManager();

            CourseInfoAndFeedbacksModel courseInfo = new CourseInfoAndFeedbacksModel();
            courseInfo.wholeCourseFeedbackDTO = new List<WholeCourseFeedbackDTO>();


            Dictionary<int, WholeCourseFeedbackDTO> feedbacks = feedbackManager.GetFeedbackByCourseId(courseId);
            foreach(KeyValuePair<int, WholeCourseFeedbackDTO> p in feedbacks)
            {
                courseInfo.wholeCourseFeedbackDTO.Add(p.Value);
            }
                   
            //тут заполняется курс DTO

            return courseInfo;
        }
    }
}

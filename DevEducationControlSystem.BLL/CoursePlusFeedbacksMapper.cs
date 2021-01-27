using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.CRUD;
using DevEducationControlSystem.DBL.DTO.Base;
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
            courseInfo.WholeCourseFeedbackDTO = new List<WholeCourseFeedbackDTO>();
            courseInfo.CourseDTO = new CourseDTO();

            Dictionary<int, WholeCourseFeedbackDTO> feedbacks = feedbackManager.GetFeedbackByCourseId(courseId);
            foreach(KeyValuePair<int, WholeCourseFeedbackDTO> p in feedbacks)
            {
                courseInfo.WholeCourseFeedbackDTO.Add(p.Value);
            }

            //тут заполняется курс DTO

            CourseManager courseManager = new CourseManager();
            courseInfo.CourseDTO = courseManager.SelectById(courseId);

            return courseInfo;
        }
    }
}

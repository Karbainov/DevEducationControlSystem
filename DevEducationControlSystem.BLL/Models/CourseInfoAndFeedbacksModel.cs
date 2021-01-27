using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.DBL.DTO.Base;
using DevEducationControlSystem.DBL.DTO.WholeCourseFeedback;

namespace DevEducationControlSystem.BLL.Models
{
    public class CourseInfoAndFeedbacksModel
    {
        public CourseDTO CourseDTO { get; set; }
        public List<WholeCourseFeedbackDTO> WholeCourseFeedbackDTO { get; set; }
    }
}

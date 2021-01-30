using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class PrivateStudentMainPageModel
    {
        public CourseOverlookModel CourseOverlook;
        public List<PassedLessonByStudentIdModel> passedLessonByStudentId;
    }
}

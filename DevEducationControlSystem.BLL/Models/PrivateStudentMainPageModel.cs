using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class PrivateStudentMainPageModel
    {
        public CourseOverlookModel CourseOverllok;
        public List<GroupmatesModel> Groupmates;
        public List<PassedLessonByStudentIdModel> passedLessonByStudentId;
    }
}

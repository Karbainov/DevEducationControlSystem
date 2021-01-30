using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class PrivateStudentMainPageModel
    {
        public CourseGeneralInfoByStudentIdModel courseGeneralInfo;
        public List<StudentPublicInfoModel> StudentPublicInfo;
        public List<PassedLessonByStudentIdModel> passedLessonByStudentId;
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class PrivateStudentMainPageModel
    {
        public CourseOverlookModel CourseOverlook { get; set; }
        public List<PassedLessonByStudentIdModel> passedLessonByStudentId { get; set; }
    }
}

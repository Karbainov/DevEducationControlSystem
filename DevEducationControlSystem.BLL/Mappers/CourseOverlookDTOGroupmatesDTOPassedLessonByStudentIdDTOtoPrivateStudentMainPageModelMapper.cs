using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.DTO;

namespace DevEducationControlSystem.BLL.Mappers
{
    public class CourseOverlookDTOGroupmatesDTOPassedLessonByStudentIdDTOtoPrivateStudentMainPageModelMapper
    {
        public PrivateStudentMainPageModel Map(

            CourseOverlookDTO courseOverlookDTO,
            List<GroupmatesDTO> groupmatesDTO,
            List<PassedLessonByStudentIdDTO> passedLessonDTO)
        {
            var privateStudentMainPage = new PrivateStudentMainPageModel();

            privateStudentMainPage.CourseOverllok = new CourseOverlookModel(courseOverlookDTO);
            
            privateStudentMainPage.Groupmates = new List<GroupmatesModel>();

            foreach(var g in groupmatesDTO)
            {
                privateStudentMainPage.Groupmates.Add(new GroupmatesModel(g));
            }

            foreach(var p in passedLessonDTO)
            {
                privateStudentMainPage.passedLessonByStudentId.Add(new PassedLessonByStudentIdModel(p));
            }

            return privateStudentMainPage;
        }
    }
}

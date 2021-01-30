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
            List<PassedLessonByStudentIdDTO> passedLessonDTOs)
        {
            var privateStudentMainPageModel = new PrivateStudentMainPageModel();

            privateStudentMainPageModel.CourseOverlook = new CourseOverlookModel(courseOverlookDTO);
            
            privateStudentMainPageModel.CourseOverlook.Groupmates = new List<GroupmatesModel>();
            privateStudentMainPageModel.passedLessonByStudentId = new List<PassedLessonByStudentIdModel>();

            foreach(var GroupmatesDTO in courseOverlookDTO.GroupmatesDTOs)
            {
                privateStudentMainPageModel.CourseOverlook.Groupmates.Add(new GroupmatesModel(GroupmatesDTO));
            }

            foreach(var passedLessonDTO in passedLessonDTOs)
            {
                privateStudentMainPageModel.passedLessonByStudentId.Add(new PassedLessonByStudentIdModel(passedLessonDTO));
            }

            return privateStudentMainPageModel;
        }
    }
}

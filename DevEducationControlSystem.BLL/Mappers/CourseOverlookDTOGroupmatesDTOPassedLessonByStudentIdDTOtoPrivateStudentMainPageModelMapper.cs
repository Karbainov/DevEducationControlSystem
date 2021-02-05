using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.DTO.Base;
using System.Linq;

namespace DevEducationControlSystem.BLL.Mappers
{
    public class CourseOverlookDTOGroupmatesDTOPassedLessonByStudentIdDTOtoPrivateStudentMainPageModelMapper
    {
        public PrivateStudentMainPageModel Map(

            CourseOverlookDTO courseOverlookDTO,
            List<PassedLessonByStudentIdDTO> passedLessonDTOs)
        {
            var model = new PrivateStudentMainPageModel();

            model.CourseOverlook = new CourseOverlookModel(courseOverlookDTO);
            
            model.CourseOverlook.Groupmates = new List<GroupmatesModel>();
            model.passedLessonByStudentId = new List<PassedLessonByStudentIdModel>();
            if (courseOverlookDTO != null)
            {
                foreach (var GroupmatesDTO in courseOverlookDTO.GroupmatesDTOs)
                {
                    model.CourseOverlook.Groupmates.Add(new GroupmatesModel(GroupmatesDTO));
                }
            }

            foreach(var passedLessonDTO in passedLessonDTOs)
            {
                model.passedLessonByStudentId.Add(new PassedLessonByStudentIdModel(passedLessonDTO));
            }

            return model;
        }
    }
}

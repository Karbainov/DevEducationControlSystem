using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.BLL.Models.RecycledBin;
using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Mappers
{
    class HomeworksDTOMaterialsDTOCoursesDTOtoRecycleBinMapper
    {
        public RecycleBinModel Map(List<HomeworkDTO> homeworksList, List<MaterialDTO> materialsList,  List<CourseDTO> coursesList)
        {
            RecycleBinModel recycleBin = new RecycleBinModel()
            {
                Homeworks = new List<HomeworkModel>(),
                Materials = new List<MaterialModel>(),
                Courses = new List<CourseModel>()
            };

            foreach (var r in homeworksList)
            {
                if (r != null)
                {
                    recycleBin.Homeworks.Add(new HomeworkModel(r));
                }
            }

            foreach (var r in materialsList)
            {
                if (r != null)
                {
                    recycleBin.Materials.Add(new MaterialModel(r));
                }
            }

            foreach (var r in coursesList)
            {
                if (r != null)
                {
                    recycleBin.Courses.Add(new CourseModel(r));
                }
            }

            return recycleBin;
        }

    }
}

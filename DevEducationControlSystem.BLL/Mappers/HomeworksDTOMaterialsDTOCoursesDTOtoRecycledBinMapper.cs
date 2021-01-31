using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.BLL.Models.RecycledBin;
using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Mappers
{
    class HomeworksDTOMaterialsDTOCoursesDTOtoRecycledBinMapper
    {
        public RecycledBinModel Map(List<HomeworkDTO> homeworksList, List<MaterialDTO> materialsList,  List<CourseDTO> coursesList)
        {
            RecycledBinModel recycledBin = new RecycledBinModel()
            {
                Homeworks = new List<HomeworkModel>(),
                Materials = new List<MaterialModel>(),
                Courses = new List<CourseModel>()
            };

            foreach (var r in homeworksList)
            {
                if (r != null)
                {
                    recycledBin.Homeworks.Add(new HomeworkModel(r));
                }
            }

            foreach (var r in materialsList)
            {
                if (r != null)
                {
                    recycledBin.Materials.Add(new MaterialModel(r));
                }
            }

            foreach (var r in coursesList)
            {
                if (r != null)
                {
                    recycledBin.Courses.Add(new CourseModel(r));
                }
            }

            return recycledBin;
        }

    }
}

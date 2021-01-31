﻿using DevEducationControlSystem.BLL.Mappers;
using DevEducationControlSystem.BLL.Models.RecycledBin;
using DevEducationControlSystem.DBL.CRUD;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL
{
   public class AdminLogicManager
    {
        public RecycleBinModel GetSoftDeletedItems()
        {
            var homeworkManager = new HomeworkManager();
            var courseManager = new CourseManager();
            var materialManager = new MaterialManager();
            var mapper = new HomeworksDTOMaterialsDTOCoursesDTOtoRecycleBinMapper();

            return mapper.Map(
                homeworkManager.SelectSoftDeleted(),
                materialManager.SelectSoftDeleted(),
                courseManager.SelectSoftDeleted()
                );
        }

    }
}
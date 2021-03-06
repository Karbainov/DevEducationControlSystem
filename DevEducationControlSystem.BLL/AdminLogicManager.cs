﻿using DevEducationControlSystem.BLL.Mappers;
using DevEducationControlSystem.BLL.Models;
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


        public void RecoverHomeworkById(int homeworkId)
        {
            var manager = new HomeworkManager();
            manager.UpdateIsDeleted(homeworkId);
        }

        public void HardDelHomeworkById(int homeworkId)
        {
            var manager = new HomeworkManager();
            manager.Delete(homeworkId);
        }

        public void RecoverMaterialById(int materialId)
        {
            var manager = new MaterialManager();
            manager.UpdateIsDeleted(materialId);
        }

        public void HardDelMaterialById(int materialId)
        {
            var manager = new MaterialManager();
            manager.Delete(materialId);
        }

        public void RecoverCourseById(int courseId)
        {
            var manager = new CourseManager();
            manager.UpdateIsDeleted(courseId);
        }

        public void HardDelCourseById(int courseId)
        {
            var manager = new CourseManager();
            manager.Delete(courseId);
        }

        public void UpdateUserRole(int userId, int roleId)
        {
            var manager = new UserManager();
            manager.UpdateUserRole(userId, roleId);
        }


    }
}

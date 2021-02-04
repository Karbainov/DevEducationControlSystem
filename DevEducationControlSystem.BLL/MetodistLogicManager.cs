using DevEducationControlSystem.BLL.Mappers;
using DevEducationControlSystem.BLL.Models.RecycledBin;
using DevEducationControlSystem.DBL.CRUD;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL
{
    public class MetodistLogicManager
    {
        public void GetAddHomework(string name, string description, int durationInWeeks)
        {
            var courseManager = new CourseManager();
            courseManager.Add(name, description, durationInWeeks);
        }
    }
}

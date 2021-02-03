using System;
using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.DTO;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Mappers
{
    class CountStudentsOnCourseByGroupsDTOtoCountStudentsOnCourseByGroupModel
    {
        public ListOfCountOfStudentsOnCourseByGroupsModel Map(List<CountStudentsOnCourseByGroupsDTO> countStudentsOnCourseByGroups)
        {
            var listOfStudentsOnCourseByGroup = new ListOfCountOfStudentsOnCourseByGroupsModel() { studentsOnCourseByGroupsList = new List<CountStudentsOnCourseByGroupModel>() };


            foreach (var n in countStudentsOnCourseByGroups)
            {
                listOfStudentsOnCourseByGroup.studentsOnCourseByGroupsList.Add(new CountStudentsOnCourseByGroupModel(n));
            }
            return listOfStudentsOnCourseByGroup;
        }
    }
}

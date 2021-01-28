using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class StudentUnlockedDataModel
    {
        public CourseGeneralInfoByStudentIdDTO courseGeneralInfoByStudentIdDTO;
        public List<MaterialsInfoForGroupDTO> materialsInfoForGroupDTOs;
    }
}

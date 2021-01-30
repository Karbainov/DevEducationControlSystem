using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.DBL.DTO;

namespace DevEducationControlSystem.BLL.Models
{
    public class StudentPublicInfoModel
    {
        public int StudentId;
        public string StudentFirstName;
        public string StudentLastName;

        public StudentPublicInfoModel(StudentPublicInfoDTO dto)
        {
            StudentId = dto.StudentId;
            StudentFirstName = dto.StudentFirstName;
            StudentLastName = dto.StudentLastName;
        }
    }
}

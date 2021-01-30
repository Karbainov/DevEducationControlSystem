using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.DBL.DTO;

namespace DevEducationControlSystem.BLL.Models
{
    public class GroupmatesModel
    {
        public int StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }

        public GroupmatesModel(GroupmatesDTO dto)
        {
            StudentId = dto.StudentId;
            StudentFirstName = dto.StudentFirstName;
            StudentLastName = dto.StudentLastName;
        }
    }
}

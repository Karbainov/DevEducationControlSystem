using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class CountStudentsPaymentDTO
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int DurationInWeeks { get; set; }

        public List<UserPaymentDTO> Student { get; set; }




    




    }
}

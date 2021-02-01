using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class UserPaymentDTO
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }
        public string Phone { get; set; }
        public string ContractNumber { get; set; }
   
        public List<PeriodDTO> Periods { get; set; }
    }
}

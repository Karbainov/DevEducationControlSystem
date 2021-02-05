using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
   public class SelectPaymentInfoDTO
    {
        public string ContractNumber { get; set; }

        public int Id { get; set; }
        public List<StudentPayDTO> Periods { get; set; }
    }
}

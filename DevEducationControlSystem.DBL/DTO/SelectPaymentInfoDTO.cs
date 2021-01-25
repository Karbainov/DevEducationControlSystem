using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
   public class SelectPaymentInfoDTO
    {
        public int Period { get; set; }
        public bool IsPaid { get; set; }
        public int Sum { get; set; }
        public string PayDate { get; set; }
        public int ContractNumber { get; set; }

        public  SelectPaymentInfoDTO(SelectPaymentInfoDTO dto)
        {
            Period = dto.Period;
            IsPaid = dto.IsPaid;
            Sum = dto.Sum;
            PayDate = dto.PayDate;
            ContractNumber = dto.ContractNumber;
        }

    }
}

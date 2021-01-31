using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class PeriodDTO
    {
        public int PaymentId { get; set; }
        public int UserId { get; set; }
        public bool IsPaid { get; set; }
        public DateTime PayDate { get; set; }
    }
}

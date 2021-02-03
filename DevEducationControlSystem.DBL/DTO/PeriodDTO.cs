using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class PeriodDTO
    {
        public int? PaymentId { get; set; }
        public int UserId { get; set; }
        public int PeriodNumber { get; set; }
        public bool isPaid { get; set; }
        public int Sum { get; set; }
        public DateTime? PayDate { get; set; }
        public bool? IsDebt { get; set; }
    }
}

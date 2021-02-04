using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class PaymentDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public int Period { get; set; }
        public bool IsDeleted { get; set; }
        public int Sum { get; set; }
        public DateTime PayDate { get; set; }

        public PaymentDTO(
            int id,
            int userId,
            int groupeId,
            int period,
            bool isDeleted,
            int sum,
            DateTime payDate)
        {
            Id = id;
            UserId = userId;
            GroupId = groupeId;
            Period = period;
            IsDeleted = isDeleted;
            Sum = sum;
            PayDate = payDate;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class CountStudentsPaymentDTO
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DurationInWeeks { get; set; }
        public string email { get; set; }
        public string Phone { get; set; }
        public string ContractNumber { get; set; }
        public int PaymentId{ get; set; }
        public int UserId { get; set; }
        public bool IsPaid { get; set; }
       


        [Group].[Name] AS GroupName, [Group].StartDate,
  Course.DurationInWeeks,
  FirstName, LastName, email, Phone, ContractNumber,
  Payment.Id AS PaymentId, UserId, [Period],  isPaid, [Sum], PayDate
    }
}

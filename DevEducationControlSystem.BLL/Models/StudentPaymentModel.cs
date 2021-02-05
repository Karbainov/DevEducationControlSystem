using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class StudentPaymentModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public List<PaymentPeriodModel> PaymentPeriod { get; set; }

        public StudentPaymentModel()
        { }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class GroupPaymentModel
    {
        public int Id { get; set; }
        public string Group { get; set; }

        public List<StudentPaymentModel> StudentPayment { get; set; }
    }
}

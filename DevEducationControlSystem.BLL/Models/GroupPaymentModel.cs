using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    class GroupPaymentModel
    {
        public int Id { get; set; }
        public string Group { get; set; }

        public List<StudentPaymentModel> StudentPayment { get; set; }
    }
}

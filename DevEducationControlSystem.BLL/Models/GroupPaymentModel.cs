using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.DBL.DTO;

namespace DevEducationControlSystem.BLL.Models
{
    public class GroupPaymentModel
    {
        List<GroupPaymentDTO> GroupPayment { get; set; }
        public List<StudentPaymentModel> StudentPayment { get; set; }
    }
}

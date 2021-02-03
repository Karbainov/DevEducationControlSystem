using System;
using System.Collections.Generic;
using System.Text;
using DevEducationControlSystem.DBL.DTO;

namespace DevEducationControlSystem.BLL.Models
{
    public class GroupPaymentModel
    {
        public int CountPeriods { get; set; }
        public GroupPaymentDTO Group { get; set; }
       
    }
}

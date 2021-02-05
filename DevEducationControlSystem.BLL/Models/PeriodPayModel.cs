using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class PeriodPayModel
    {
        public int Period { get; set; }
        public int Sum { get; set; }
        public bool isPaid { get; set; }
        public DateTime PayDate { get; set; }

        public PeriodPayModel()
        {

        }
        public PeriodPayModel (StudentPayDTO payDTO)
        {
            Period = payDTO.Period;
            Sum = payDTO.Sum;
            isPaid = payDTO.isPaid;
            PayDate = payDTO.PayDate;
        }

    }
}

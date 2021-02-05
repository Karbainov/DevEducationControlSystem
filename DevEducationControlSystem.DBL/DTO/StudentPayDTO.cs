using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
   public class StudentPayDTO
    {
        public int Period { get; set; }
        public int Sum { get; set; }
        public bool isPaid { get; set; }
        public DateTime PayDate { get; set; }
    }
}

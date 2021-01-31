using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class UserPaymentDTO
    {
        public UserDTO Student { get; set; }
        public List<PeriodDTO> Periods { get; set; }
    }
}

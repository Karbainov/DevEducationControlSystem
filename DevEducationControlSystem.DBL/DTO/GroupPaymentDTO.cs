﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class GroupPaymentDTO
    {
        
        public string GroupName { get; set; }
        public int DurationInWeeks { get; set; }
        public List<UserPaymentDTO> StudentList { get; set; }
    }
}
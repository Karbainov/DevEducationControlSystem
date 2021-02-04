using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class NumberOfUsersByStatusDTO
    {
        public int StatusId { get; set; }
        public string Status { get; set; }
        public int UserCount { get; set; }
    }
}

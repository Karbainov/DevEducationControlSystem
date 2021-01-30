using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class UserPercentOfPresentsDTO
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public float PercentOfPresents { get; set; }

        public UserPercentOfPresentsDTO()
        {

        }
    }
}

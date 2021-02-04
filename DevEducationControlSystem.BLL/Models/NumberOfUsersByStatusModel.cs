using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class NumberOfUsersByStatusModel
    {
        public int StatusId { get; set; }
        public string Status { get; set; }
        public int UserCount { get; set; }

        public NumberOfUsersByStatusModel()
        {

        }
        public NumberOfUsersByStatusModel(NumberOfUsersByStatusDTO dto)
        {
            StatusId = dto.StatusId;
            Status = dto.Status;
            UserCount = dto.UserCount;
    }
    }
}

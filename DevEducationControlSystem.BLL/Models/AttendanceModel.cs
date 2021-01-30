using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class AttendanceModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool IsPresent { get; set; }

        public AttendanceModel()
        {

        }

        public AttendanceModel(AttendanceDTO attendance)
        {
            Id = attendance.Id;
            UserId = attendance.UserId;
            IsPresent = attendance.IsPresent;
        }
    }
}

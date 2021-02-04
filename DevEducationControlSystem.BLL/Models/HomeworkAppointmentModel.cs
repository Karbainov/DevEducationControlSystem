using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class HomeworkAppointmentModel
    {
        public int HomeworkId { get; set; }
        public int GroupId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DeadLine { get; set; }
    }
}

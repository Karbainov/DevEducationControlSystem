using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class AnswerExpandedDTO
    {
        public int AnswerId { get; set; }
        public int HomeworkId { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? ResourseId { get; set; }
        public string Links { get; set; }
        public string Images { get; set; }
    }
}

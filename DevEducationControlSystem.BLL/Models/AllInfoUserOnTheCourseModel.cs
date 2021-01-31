using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class AllInfoUserOnTheCourseModel
    {       
        public int Id { get; set; }
        public int StatusId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string email { get; set; }
        public string Phone { get; set; }
        public string ContractNumber { get; set; }
        public string ProfileImage { get; set; }
        public string Status { get; set; }
        public string GroupName { get; set; }

       public List<NumberOfStudentsOnTheCourseModel> Course { get; set; }
    }
}

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
       public List<AllInfoUserOnTheCourseModel> Info { get; set; }

        public AllInfoUserOnTheCourseModel()
        {

        }

        public AllInfoUserOnTheCourseModel(AllInfoUserOnTheCourseDTO dto)
        {
            Id = dto.Id;
            StatusId = dto.StatusId;
            FirstName = dto.FirstName;
            LastName = dto.LastName;
            BirthDate = dto.BirthDate;
            Login = dto.Login;
            Password = dto.Password;
            email = dto.email;
            Phone = dto.Phone;
            ContractNumber = dto.ContractNumber;
            ProfileImage = dto.ProfileImage;
            Status = dto.Status;
            GroupName = dto.GroupName;

        }
    }
}

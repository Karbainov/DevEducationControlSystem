using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class AllInfoUserOnTheCourseModel
    {       
        public int UserId { get; set; }
        public string Position { get; set; }
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
        public AllInfoUserOnTheCourseModel()
        {

        }
        public AllInfoUserOnTheCourseModel(AllInfoUserOnTheCourseDTO dto)
        {
            UserId = dto.UserId;
            Position = dto.Position;
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

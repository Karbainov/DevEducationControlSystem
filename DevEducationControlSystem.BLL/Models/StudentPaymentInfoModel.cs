using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class StudentPaymentInfoModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ProfileImage { get; set; }
        public string ContractNumber { get; set; }      
        public int Id { get; set; }
        public List<PeriodPayModel> Periods { get; set; }

        public StudentPaymentInfoModel()
        {

        }
        public StudentPaymentInfoModel(UserDTO user)
        {
            FirstName = user.FirstName;
            LastName = user.LastName;
            BirthDate = user.BirthDate;
            Email = user.email;
            Phone = user.Phone;
            ContractNumber = user.ContractNumber;
            ProfileImage = user.ProfileImage;
            Id = user.Id;
        }
    }
}


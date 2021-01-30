using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class UserDTO
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ContractNumber { get; set; }
        public string ProfileImage { get; set; }

        public UserDTO()
        {

        }

        public UserDTO(int id, 
            int statusid, 
            string firstname,
            string lastname, 
            DateTime birthdate, 
            string login, 
            string password, 
            string email, 
            string phone, 
            string contractnumber, 
            string profileimage)
        {
            Id = id;
            StatusId = statusid;
            FirstName = firstname;
            LastName = lastname;
            BirthDate = birthdate;
            Login = login;
            Password = password;
            this.Email = email;
            Phone = phone;
            ContractNumber = contractnumber;
            ProfileImage = profileimage;
        }
    }
}
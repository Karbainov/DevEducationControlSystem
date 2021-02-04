using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class UserWithRoleModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ContractNumber { get; set; }
        public string ProfileImage { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }

        public List<RoleModel> Roles { get; set; }

        public UserWithRoleModel()
        {

        }

        public UserWithRoleModel(UserWithRoleDTO dto)
        {
            Id = dto.Id;
            FirstName = dto.FirstName;
            LastName = dto.LastName;
            BirthDate = dto.BirthDate;
            Login = dto.Login;
            Password = dto.Password;
            Email = dto.Email;
            Phone = dto.Phone;
            ContractNumber = dto.ContractNumber;
            ProfileImage = dto.ProfileImage;
            StatusId = dto.StatusId;
            Status = dto.Status;

            Roles = new List<RoleModel>();
            foreach(var r in dto.Roles)
            {
                if (r != null)
                {
                    Roles.Add(new RoleModel(r));
                }
            }
        }
    }
}

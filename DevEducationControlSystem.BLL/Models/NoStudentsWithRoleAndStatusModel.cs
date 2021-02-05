using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class NoStudentsWithRoleAndStatusModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public string Role { get; set; }


        public NoStudentsWithRoleAndStatusModel()
        { }

        public NoStudentsWithRoleAndStatusModel(UserWithRoleAndStatusDTO dto)
        {
            Id = dto.Id;
            FirstName = dto.FirstName;
            LastName = dto.LastName;
            Login = dto.Login;
            Password = dto.Password;
            Status = dto.Status;
            Role = dto.Role;
        }

    }
}

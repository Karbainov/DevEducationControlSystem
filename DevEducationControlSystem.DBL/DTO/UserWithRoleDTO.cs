using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class UserWithRoleDTO
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

        public List<RoleDTO> Roles { get; set;}
    }
}

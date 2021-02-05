using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEducationControlSystem.API.InputModels
{
    public class UserProfileInputModel
    {
        public int UserId { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ProfileImage { get; set; }
    }
}

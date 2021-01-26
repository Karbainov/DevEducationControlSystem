using System;
using DevEducationControlSystem.DBL.DTO.Base;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
   public class SelectUserInfoByLoginDTO
    {
           public int Id { get; set; }
           public string FirstName { get; set; }
           public string LastName { get; set; }
           public string BirthDate { get; set; }
           public string Email { get; set; }
           public string Phone { get; set; }
           public string ProfileImage { get; set; }
           public string GroupName { get; set; }
           public string CourseName { get; set; }
           public string CityName { get; set; }
           public List <RoleNameDTO> Roles { get; set; }

        public SelectUserInfoByLoginDTO()
        {

        }

        public SelectUserInfoByLoginDTO
            (int id,
            string firstname,
            string lastname,
            string birthdate,
            string email,
            string phone,
            string profileimage,
            string groupname,
            string coursename,
            string cityname,
            List <RoleNameDTO> roles
            )
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            BirthDate = birthdate;
            Email = email;
            Phone = phone;
            ProfileImage = profileimage;
            Roles = roles;
            GroupName = groupname;
            CourseName = coursename;
            CityName = cityname;
        }




    }
}

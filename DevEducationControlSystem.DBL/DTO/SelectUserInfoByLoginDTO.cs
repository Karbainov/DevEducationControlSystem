using System;
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
           public string RoleName { get; set; }
           public string GroupName { get; set; }
           public string CourseName { get; set; }
           public string CityName { get; set; }
         //  public List <RoleDTO> roles { get; set; }

        public SelectUserInfoByLoginDTO(SelectUserInfoByLoginDTO dto)
        {
            Id = dto.Id;
            FirstName = dto.FirstName;
            LastName = dto.LastName;
            BirthDate = dto.BirthDate;
            Email = dto.Email;
            Phone = dto.Phone;
            ProfileImage = dto.ProfileImage;
            RoleName = dto.RoleName;
            GroupName = dto.GroupName;
            CourseName = dto.CourseName;
            CityName = dto.CityName;
        }




    }
}

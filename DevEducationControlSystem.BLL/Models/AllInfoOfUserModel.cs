using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
	public class AllInfoOfUserModel
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

		public List<RoleInfoForUserDTO> Roles { get; set; }
		public List<CourseInfoForUserDTO> Courses { get; set; }
		public List<GroupInfoForUserDTO> Groups { get; set; }
		

		public AllInfoOfUserModel()
		{ }

		public AllInfoOfUserModel(AllInfoOfUserDTO dto)
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
			Roles = dto.Roles;
			Courses = dto.Courses;
			Groups = dto.Groups;
		}

	}
}

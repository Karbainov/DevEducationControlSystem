using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
	public class HomeworkModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool IsSolutionRequired { get; set; }
		public bool IsDeleted { get; set; }
		public int? ResourceId { get; set; }
		

		public HomeworkModel()
		{ }

		public HomeworkModel(HomeworkDTO dto)
		{
			Id = dto.Id;
			Name = dto.Name;
			Description = dto.Description;
			IsSolutionRequired = dto.IsSolutionRequired;
			IsDeleted = dto.IsDeleted;
			ResourceId = dto.ResourceId;
		}

	}
}

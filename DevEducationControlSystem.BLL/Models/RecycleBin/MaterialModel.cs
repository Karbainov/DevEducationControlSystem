using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
	public class MaterialModel
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public string Name { get; set; }
		public string Message { get; set; }
		public int? ResourceId { get; set; }
		public bool IsDeleted { get; set; }

		public MaterialModel()
		{ }

		public MaterialModel(MaterialDTO dto)
		{
			Id = dto.Id;
			UserId = dto.UserId;
			Name = dto.Name;
			Message = dto.Message;
			ResourceId = dto.ResourceId;
			IsDeleted = dto.IsDeleted;
		}
	}
}

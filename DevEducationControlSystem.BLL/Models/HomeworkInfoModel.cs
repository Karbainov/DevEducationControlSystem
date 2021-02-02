using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class HomeworkInfoModel
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool IsSolutionRequired { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime DeadLine { get; set; }
		public int? ResourceId { get; set; }
		public string Links { get; set; }
		public string Image { get; set; }

		public HomeworkInfoModel()
		{ }

		public HomeworkInfoModel(HomeworkAllInfoDTO dto)
		{
			Id = dto.Id;
			Name = dto.Name;
			Description = dto.Description;
			IsSolutionRequired = dto.IsSolutionRequired;
			StartDate = dto.StartDate;
			DeadLine = dto.DeadLine;
			ResourceId = dto.ResourceId;
			Links = dto.Links;
			Image = dto.Image;
		}

	}
}

using DevEducationControlSystem.DBL.DTO.Base;
using System;
using System.Collections.Generic;

namespace DevEducationControlSystem.DBL.DTO
{
	public class SelectAllHomeworkByGroupDTO
	{
		public int HomeworkId { get; set; }
		public string Homework { get; set; }
		public string Description { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime DeadLine { get; set; }
		public int IsSolutionRequired { get; set; }
		public List<ResourceDTO> Resource { get; set; }

		public SelectAllHomeworkByGroupDTO()
        {

        }

		public SelectAllHomeworkByGroupDTO(SelectAllHomeworkByGroupDTO dto)
        {
			HomeworkId = dto.HomeworkId;
			Homework = dto.Homework;
			Description = dto.Description;
			IsSolutionRequired = dto.IsSolutionRequired;
			Resource = dto.Resource;
        }

	}
}

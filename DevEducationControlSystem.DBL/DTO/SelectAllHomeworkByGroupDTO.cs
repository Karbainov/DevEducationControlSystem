using System;

namespace DevEducationControlSystem.DBL.DTO
{
	public class SelectAllHomeworkByGroupDTO
	{
		public int HomeworkId { get; set; }
		public string Homework { get; set; }
		public string Description { get; set; }
		public int IsSolutionRequired { get; set; }
		public ResourceLinksDTO ResourceLinks { get; set; }
		public ResourceImageDTO ResourseImage { get; set; }

		public SelectAllHomeworkByGroupDTO()
        {

        }

		public SelectAllHomeworkByGroupDTO(SelectAllHomeworkByGroupDTO dto)
        {
			HomeworkId = dto.HomeworkId;
			Homework = dto.Homework;
			Description = dto.Description;
			IsSolutionRequired = dto.IsSolutionRequired;
			ResourceLinks = dto.ResourceLinks;
			ResourseImage = dto.ResourseImage;
        }

	}
}

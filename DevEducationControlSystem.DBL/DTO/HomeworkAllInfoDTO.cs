using System;

namespace DevEducationControlSystem.DBL.DTO
{
	public class HomeworkAllInfoDTO
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
	}
}

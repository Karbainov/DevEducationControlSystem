using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEducationControlSystem.API.InputModels
{
    public class NewHomeworkCourseInputModel
    {
		public string Name { get; set; }
		public string Description { get; set; }
		public bool IsSolutionRequired { get; set; }
		public bool IsDeleted { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime DeadLine { get; set; }
		public int ResourceId { get; set; }
	}
}

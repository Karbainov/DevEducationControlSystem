using System;

namespace DevEducationControlSystem.DBL.DTO
{
    public class MaterialsInfoForGroupDTO
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Message { get; set; }
		public int? ResourceId { get; set; }
		public string Links { get; set; }
		public string Images { get; set; }
	}
}

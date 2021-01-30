using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.BLL.Models
{
    public class MaterialInfoModel
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Message { get; set; }
		public int? ResourceId { get; set; }
		public string Links { get; set; }
		public string Images { get; set; }

		public MaterialInfoModel()
		{}

		public MaterialInfoModel(MaterialsInfoForGroupDTO dto)
		{
			Id = dto.Id;
			Name = dto.Name;
			Message = dto.Message;
			ResourceId = dto.ResourceId;
			Links = dto.Links;
			Images = dto.Images;
		}
	}
}

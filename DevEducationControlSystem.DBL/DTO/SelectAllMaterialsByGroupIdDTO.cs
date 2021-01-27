using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    class SelectAllMaterialsByGroupIdDTO
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Message { get; set; }
		public string Links { get; set; }
		public string Images { get; set; }
		public bool IsDeleted { get; set; }

		public SelectAllMaterialsByGroupIdDTO()
        {

        }

		public SelectAllMaterialsByGroupIdDTO(SelectAllMaterialsByGroupIdDTO dto)
        {
			Id = dto.Id;
			Name = dto.Name;
			Message = dto.Message;
			Links = dto.Links;
			Images = dto.Images;
			IsDeleted = dto.IsDeleted;
        }
	}
}

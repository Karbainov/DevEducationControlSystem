using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class MaterialsInfoForGroupDTO
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Message { get; set; }
		public string Links { get; set; }
		public string Images { get; set; }

		public MaterialsInfoForGroupDTO()
        {

        }

		public MaterialsInfoForGroupDTO(MaterialsInfoForGroupDTO dto)
        {
			Id = dto.Id;
			Name = dto.Name;
			Message = dto.Message;
			Links = dto.Links;
			Images = dto.Images;
        }
	}
}

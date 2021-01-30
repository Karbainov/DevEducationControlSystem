using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class CommentDTO
    {
        public int id { get; set; }
        public int UserId { get; set; }
        public int ResourceId { get; set; }

        public DataType Data { get; set; }
        public string Message { get; set; }

        public CommentDTO()
        {

        }

        public CommentDTO(CommentDTO dto)
        {
            id = dto.id;
            UserId = dto.UserId;
            ResourceId = dto.ResourceId;
            Data = dto.Data;
            Message = dto.Message;
        }
    }
}

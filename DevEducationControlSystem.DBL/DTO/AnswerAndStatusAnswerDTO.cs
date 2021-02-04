using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
  
    public class AnswerAndStatusAnswerDTO
    {
      public int Id { get; set; }
      public int UserId { get; set; }
      public int ResourceId { get; set; }
      public string Images { get; set; }
      public string Links { get; set; }
      public int HomeworkId { get; set; }
      public DateTime Date { get; set; }
      public string Message { get; set; }
      public int StatusId { get; set; }
      public string Name { get; set; }

    public AnswerAndStatusAnswerDTO()
      {

      }
      public AnswerAndStatusAnswerDTO(int Id, int UserId, int ResourceId, string Images, string Links, int HomeworkId, DateTime Date, string Message, int StatusId, string Name)
      {
        this.Id = Id;
        this.UserId = UserId;
        this.ResourceId = ResourceId;
        this.Images = Images;
        this.Links = Links;
        this.HomeworkId = HomeworkId;
        this.Date = Date;
        this.Message = Message;
        this.StatusId = StatusId;
        this.Name = Name;
      }
    }
  }

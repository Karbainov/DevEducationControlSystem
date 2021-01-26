using System;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class AnswerDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ResourceId { get; set; }
        public int HomeworkId { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public int StatusId { get; set; }

        public AnswerDTO()
        {

        }
        public AnswerDTO(int Id, int UserId, int ResourceId, int HomeworkId, DateTime Date, string Message, int StatusId)
        {
            this.Id = Id;
            this.UserId = UserId;
            this.ResourceId = ResourceId;
            this.HomeworkId = HomeworkId;
            this.Date = Date;
            this.Message = Message;
            this.StatusId = StatusId;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class Group_HomeworkDTO
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int HomeworkId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DeadLine { get; set; }

        public Group_HomeworkDTO()
        {

        }

        public Group_HomeworkDTO(
            int id,
            int groupId,
            int homeworkId,
            DateTime startDate,
            DateTime deadLine)
        {
            Id = id;
            GroupId = groupId;
            HomeworkId = homeworkId;
            StartDate = startDate;
            DeadLine = deadLine;
        }
    }
}

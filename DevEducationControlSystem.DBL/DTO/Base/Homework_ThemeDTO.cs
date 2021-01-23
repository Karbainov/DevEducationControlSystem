using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class Homework_ThemeDTO
    {
        public int Id { get; set; }
        public int HomeworkId { get; set; }
        public int ThemeId { get; set; }

        public Homework_ThemeDTO()
        {

        }
        public Homework_ThemeDTO(int Id, int HomeworkId, int ThemeId)
        {
            this.Id = Id;
            this.HomeworkId = HomeworkId;
            this.ThemeId = ThemeId;
        }
    }
}
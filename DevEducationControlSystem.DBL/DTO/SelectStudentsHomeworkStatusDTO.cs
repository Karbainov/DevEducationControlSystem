using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class SelectStudentsHomeworkStatusDTO
    {
        public string HomeworkName { get; set; }
        public string ThemeName { get; set; }
        public int DoneHomework { get; set; }
        public int NotDoneHomework { get; set; }
        public int HomeworkDoneOnTime { get; set; }
        public int LateDoneHomework { get; set; }

        public SelectStudentsHomeworkStatusDTO()
        {

        }

        public SelectStudentsHomeworkStatusDTO(SelectStudentsHomeworkStatusDTO dto)
        {
            HomeworkName = dto.HomeworkName;
            ThemeName = dto.ThemeName;
            DoneHomework = dto.DoneHomework;
            NotDoneHomework = dto.NotDoneHomework;
            HomeworkDoneOnTime = dto.HomeworkDoneOnTime; 
            LateDoneHomework = dto.LateDoneHomework;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class SelectStudentsHomeworkStatusDTO
    {
        public string Cityname { get; set; }
        public string Groupname { get; set; }
        public string Homeworkname { get; set; }
        public int DoneHomework { get; set; }
        public int NotDoneHomework { get; set; }
        public int DoneHomeworkOnTime { get; set; }
        public int LateDoneHomework { get; set; }

        public SelectStudentsHomeworkStatusDTO()
        {

        }

        public SelectStudentsHomeworkStatusDTO(SelectStudentsHomeworkStatusDTO dto)
        {
            Cityname = dto.Cityname;
            Groupname = dto.Groupname;
            Homeworkname = dto.Homeworkname;
            DoneHomework = dto.DoneHomework;
            NotDoneHomework = dto.NotDoneHomework;
            DoneHomeworkOnTime = dto.DoneHomeworkOnTime;
            LateDoneHomework = dto.LateDoneHomework;

        }
    }
}

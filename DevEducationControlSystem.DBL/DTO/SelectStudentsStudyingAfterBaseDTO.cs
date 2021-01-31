using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
   public  class SelectStudentsStudyingAfterBaseDTO
    {
        public int Cityname{ get; set; }
        public int Groupname { get; set; }
        public int Usercount { get; set; }

        public SelectStudentsStudyingAfterBaseDTO()
        {

        }

        public SelectStudentsStudyingAfterBaseDTO(SelectStudentsStudyingAfterBaseDTO dto)
        {
            Cityname = dto.Cityname;
            Groupname = dto.Groupname;
            Usercount = dto.Usercount;
        }
    }
}


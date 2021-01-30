using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
   public  class SelectStudentsStudyingAfterBaseDTO
    {
        public int Usercount { get; set; }

        public SelectStudentsStudyingAfterBaseDTO()
        {

        }

        public SelectStudentsStudyingAfterBaseDTO(SelectStudentsStudyingAfterBaseDTO dto)
        {
            Usercount = dto.Usercount;
        }
    }
}


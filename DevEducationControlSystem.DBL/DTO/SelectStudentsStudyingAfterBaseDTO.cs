﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    class SelectStudentsStudyingAfterBaseDTO
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

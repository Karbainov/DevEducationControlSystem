using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class SelectAllGroupsAndAmountPeopleInGroupByCityDTO
    {
        public string Cityname { get; set; }
        public int Groupcount { get; set; }
        public int Personcount { get; set; }

        public SelectAllGroupsAndAmountPeopleInGroupByCityDTO ()
        {

        }

        public SelectAllGroupsAndAmountPeopleInGroupByCityDTO(SelectAllGroupsAndAmountPeopleInGroupByCityDTO dto)
        {
            Cityname = dto.Cityname;
            Groupcount = dto.Groupcount;
            Personcount = dto.Personcount;
        }
    }
}

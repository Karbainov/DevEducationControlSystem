using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class SelectAllGroupsAndAmountPeopleInGroupByCityDTO
    {
        public string cityname { get; set; }
        public int groupcount { get; set; }
        public int personcount { get; set; }

        public SelectAllGroupsAndAmountPeopleInGroupByCityDTO ()
        {

        }

        public SelectAllGroupsAndAmountPeopleInGroupByCityDTO(SelectAllGroupsAndAmountPeopleInGroupByCityDTO dto)
        {
            cityname = dto.cityname;
            groupcount = dto.groupcount;
            personcount = dto.personcount;
        }
    }
}

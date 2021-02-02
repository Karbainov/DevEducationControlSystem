using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationControlSystem.DBL.DTO
{
    public class NumberOfPeoplePerRoleDTO
    {
        public string Role{get; set;}
        public int NumberOfPeople { get; set; }

        public NumberOfPeoplePerRoleDTO()
        { }

        public NumberOfPeoplePerRoleDTO(
            string role,
            int numberOfPeople)
        {
            Role = role;
            NumberOfPeople = numberOfPeople;
        }
    }
}

using System;
using DevEducationControlSystem.DBL.CRUD;
using DevEducationControlSystem.DBL.DTO.Base;
using System.Collections.Generic;


namespace DevEducationControlSystemDTOTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new RoleManager();

            //var dto = new RoleDTO(manager.SelectById(2));
            var dto = new List<RoleDTO>(manager.Select());

            foreach (var d in dto)
            {
                Console.WriteLine(d.Id + " " + d.Name);
            }
        }
    }
}

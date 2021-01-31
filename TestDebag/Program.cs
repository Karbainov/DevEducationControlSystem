using System;
using DevEducationControlSystem.DBL.CRUD;
using DevEducationControlSystem.DBL.DTO.Base;
using System.Collections.Generic;

namespace TestDebag
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new User_RoleManager();

            var dto = new Course_ThemeDTO(manager.SelectById(1));
            var dto = new List<User_RoleDTO>(manager.Select());

            foreach (var d in dto)
            {
                Console.WriteLine(d.UserId + " " + d.RoleId);
            }
        }
    }
}

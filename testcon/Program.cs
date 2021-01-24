using System;
using DevEducationControlSystem.DBL;
using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.CRUD;
using System.Collections.Generic;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //var manager = new GroupStatusManager();
            var manager = new HomeworkManager();

            ////var dto = new Course_ThemeDTO(manager.SelectById(1));
            var dto = manager.Select();
            //var dto = manager.SelectById(2);
            //dto.ForEach(d => Console.WriteLine(d.Id + " " + d.Name));
            dto.ForEach(d => Console.WriteLine(d.Id + " " + d.Name + " " + d.Description));
            //Console.WriteLine(dto.Id + " " + dto.Name);


        }
    }
}
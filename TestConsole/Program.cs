using System;
using DevEducationControlSystem.DBL;
using DevEducationControlSystem.DBL.DTO;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new AllGroupMaterialsByTagAndUserId_Manager();

            //var dto = new Course_ThemeDTO(manager.SelectById(1));
            var dto = manager.Get(17, "тег1");

            dto.ForEach(d => Console.WriteLine(d.Tag + " " + d.Links + " " + d.Images + " " + d.MaterialId));
        }
    }
}

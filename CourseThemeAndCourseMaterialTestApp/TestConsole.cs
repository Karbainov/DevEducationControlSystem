using System;
using DevEducationControlSystem.DBL;
using DevEducationControlSystem.DBL.DTO.Base;
using System.Collections.Generic;

namespace CourseThemeAndCourseMaterialTestApp
{
    class TestConsole
    {
        static void Main(string[] args)
        {
            var manager = new TagsFromAllMaterials();

            //var dto = new Course_ThemeDTO(manager.SelectById(1));
            var dto = manager.Search(1, "тег1");
            
            dto.ForEach(d => Console.WriteLine(d.Tag + " " + d.Links+" "+d.Images+" "+d.Material_name+" "+d.MaterialId));
        }
    }
}

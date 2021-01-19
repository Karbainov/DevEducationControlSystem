using System;
using DevEducationControlSystem.DBL.CRUD;
using DevEducationControlSystem.DBL.DTO.Base;
using System.Collections.Generic;

namespace CourseThemeAndCourseMaterialTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Course_ThemeManager();

            //var dto = new Course_ThemeDTO(manager.SelectById(1));
            var dto = new List<Course_ThemeDTO>(manager.Select());
            
            foreach (var d in dto)
            {
                Console.WriteLine(d.CourseId + " " + d.ThemeId);
            }
        }
    }
}

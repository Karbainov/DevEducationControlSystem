using System;
using DevEducationControlSystem.DBL.CRUD;
using DevEducationControlSystem.DBL.DTO.Base;

namespace CourseThemeAndCourseMaterialTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Course_ThemeManager();

            var dto = new Course_ThemeDTO(manager.SelectById(1));
            Console.WriteLine(dto.CourseId+" "+dto.ThemeId);
        }
    }
}

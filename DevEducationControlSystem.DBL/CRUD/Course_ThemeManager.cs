using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DevEducationControlSystem.DBL.DTO.Base;

namespace DevEducationControlSystem.DBL.CRUD
{
    public class Course_ThemeManager
    {
        public List<Course_ThemeDTO> Select()
        {
            var course_ThemeDTOs = new List<Course_ThemeDTO>();
            //Тут как-то заполняется
            return course_ThemeDTOs;
        }

        public Course_ThemeDTO SelectById(int id)
        {
            var course_ThemeDTO = new Course_ThemeDTO();
            //Тут как-то заполняется
            return course_ThemeDTO;
        }
    }
}

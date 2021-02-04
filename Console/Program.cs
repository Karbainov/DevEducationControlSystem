using System;
using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.CRUD;
using DevEducationControlSystem.DBL;

namespace TConsole
{
  class Program
    {
        static void Main(string[] args)
        {
            var manager = new StatisticManager();
            manager.CountHomeworkByThemeInCityCourseGroup();
            
           


        }
    }
}

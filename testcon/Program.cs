﻿using System;
using DevEducationControlSystem.DBL;
using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.CRUD;
using System.Collections.Generic;
using DevEducationControlSystem.DBL.DTO.Base;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //var manager = new GroupStatusManager();
            var manager = new CourseManager();

            manager.Update(6, "проверка", "хранимки", 12, true);
        }
    }
}
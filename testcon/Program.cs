using System;
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
           // var manager = new HomeworkManager();

            manager.GetAllHomeworkByCourse(2);

        }
    }
}
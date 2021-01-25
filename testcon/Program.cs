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
            
            var manager = new FeedbackManager();
            var dto = manager.GetFeedbackByCourseId(1);


        }
    }
}
using System;
using DevEducationControlSystem.DBL;
using DevEducationControlSystem.DBL.DTO;

namespace testApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new ManagerManager();
            manager.AddUserToGroup(35, 3);
        }
    }
}

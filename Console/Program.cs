﻿using System;
using DevEducationControlSystem.DBL.DTO;
using DevEducationControlSystem.DBL.CRUD;

namespace TConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new PaymentManager();
            manager.GetPaymentDTOs();



        }
    }
}

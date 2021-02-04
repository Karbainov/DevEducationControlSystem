using DevEducationControlSystem.BLL.Models;
using DevEducationControlSystem.DBL.CRUD;
using DevEducationControlSystem.DBL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
namespace DevEducationControlSystem.BLL
{
    public class CityLogicManager
    {
        public int AddCity(string Name)
        {
            //var cityManager = new CityManager();
            //var cityName = new CityManager().Add(city.Name);
            return new CityManager().Add(Name);
        }
       
    }
}

using DevEducationControlSystem.BLL.Mappers;
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
        public string AddCity(string Name)
        {  
            return new CityManager().Add(Name); 
        }        

    }
}

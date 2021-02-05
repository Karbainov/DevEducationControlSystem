using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevEducationControlSystem.API.InputModels;
using DevEducationControlSystem.BLL;
using DevEducationControlSystem.BLL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevEducationControlSystem.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CityController : Controller
    {
        [HttpPut("AddCity")]
        public IActionResult AddCity(string Name)
        {
            var cityLogicManager = new CityLogicManager();
            var cityInputModel = new CityInputModel();
            return Ok(cityLogicManager.AddCity(cityInputModel.Name));
        }
        
    }       
   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        [HttpPut("CityAdd")]
        public IActionResult AddCity(string Name)
        {
            var cityLogicManager = new CityLogicManager();
            var cityModel = new CityModel();            
            return Ok(cityLogicManager.AddCity(Name));
        }
    }       
   
}

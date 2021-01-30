using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEducationControlSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        [HttpGet("Student/{userId}")]
        public IActionResult UpdatePersonalData(int userId)
        {
            
            return Ok(null);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevEducationControlSystem.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevEducationControlSystem.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StatisticController : Controller
    {

        [HttpGet("")]
        public IActionResult GetGroupInfoById()
        {
            var StatisticLogicManager = new StatisticLogicManager();
            return Ok(StatisticLogicManager.GetRoleStatistic());
        }
    }
}

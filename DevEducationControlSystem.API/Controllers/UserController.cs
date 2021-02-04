using DevEducationControlSystem.API.InputModels;
using DevEducationControlSystem.BLL;
using DevEducationControlSystem.DBL.CRUD;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEducationControlSystem.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        [HttpGet("Student/{userId}")]
        public IActionResult GetHomeworksWithStatus(int userId)
        {
            var userLogicManager = new UserLogicManager();
            return Ok(userLogicManager.GetHomeworksWithStatus(userId));
        }

        [HttpGet("{userId}")]
        public IActionResult GetUserProfile(int userId)
        {
            var userMansger = new UserManager();
            return Ok(userMansger.SelectById(userId));
        }

        [HttpPut("{userId}/Update")]
        public IActionResult GetUserPrivateInfo(UserProfileInputModel userProfile)
        {
            var usermanager = new UserManager();
            usermanager.UpdateUserProfile(userProfile.UserId, userProfile.Password, userProfile.Phone, userProfile.Email, userProfile.ProfileImage);       
            return Ok(usermanager.SelectById(userProfile.UserId));
        }

        [HttpGet("Student/{userId}/Paymentnfo")]
        public IActionResult GetPaymentInfo (int userId)
        {
            var userLogicManager = new UserLogicManager();
            return Ok(userLogicManager.GetStudentPaymentInfo(userId));
        }
    }
}

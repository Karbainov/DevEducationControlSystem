using DevEducationControlSystem.API.InputModels;
using DevEducationControlSystem.BLL;
using DevEducationControlSystem.DBL.DTO;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Roles = "Менеджер")]
        [HttpGet("Manager/Users")]
        public IActionResult GetAllUserInfo()
        {
            var userLogicManager = new UserLogicManager();
            return Ok(userLogicManager.GetAllUserInfo());
        }
        [Authorize(Roles = "Менеджер")]
        [HttpGet("Manager/Users/{userId}")]
        public IActionResult GetAllUserInfoById(int userId)
        {
            var userLogicManager = new UserLogicManager();
            return Ok(userLogicManager.GetAllUserInfoById(userId));
        }
        [Authorize(Roles = "Менеджер")]
        [HttpPost("Manager/Users")]
        public IActionResult EditAllUserInfoById(AllUserInfoInputModel inputModel)
        {
            var userLogicManager = new UserLogicManager();
            try
            {
                userLogicManager.EditAllUserInfoById(new AllInfoOfUserDTO()
                {
                    Id = inputModel.Id,
                    FirstName = inputModel.FirstName,
                    LastName = inputModel.LastName,
                    BirthDate = inputModel.BirthDate,
                    Login = inputModel.Login,
                    Password = inputModel.Password,
                    Email = inputModel.Email,
                    Phone = inputModel.Phone,
                    ContractNumber = inputModel.ContractNumber,
                    ProfileImage = inputModel.ProfileImage,
                    StatusId = inputModel.StatusId
                });
            }
            catch (ArgumentException e)
            {
                return StatusCode(404, e.Message);
            }
            return Ok();
        }
        [Authorize(Roles = "Менеджер")]
        [HttpPut("Manager/Users")]
        public IActionResult CreateNewUser(AllUserInfoInputModel inputModel)
        {
            var userLogicManager = new UserLogicManager();
            try
            {
                userLogicManager.CreateNewUser(new AllInfoOfUserDTO()
                {
                    FirstName = inputModel.FirstName,
                    LastName = inputModel.LastName,
                    BirthDate = inputModel.BirthDate,
                    Login = inputModel.Login,
                    Password = inputModel.Password,
                    Email = inputModel.Email,
                    Phone = inputModel.Phone,
                    ContractNumber = inputModel.ContractNumber,
                    ProfileImage = inputModel.ProfileImage,
                    StatusId = inputModel.StatusId
                });
            }
            catch (ArgumentException e)
            {
                return StatusCode(404, e.Message);
            }
            return Ok();
        }
    }
}

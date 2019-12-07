using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dal.common;
using Dal.DTO;
using Dal.Interface;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Model;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public string Get()
        {
            return "welcome";
        }
        // GET api/values
        [HttpPost]
        public JsonResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                var user = _userService.GetUser(login.EmailId, login.Password);
                if (user != null)
                    return new JsonResult(new Response()
                    {
                        Status = Dal.Enum.ResponseTypes.ok,
                        Data = user
                    });
                else
                    return new JsonResult(new Response()
                    {
                        Status = Dal.Enum.ResponseTypes.invalid,
                        ErrorMessage = "Invalid EmailId/Password"
                    });
            }
            else
                return new JsonResult(new Response()
                {
                    Status = Dal.Enum.ResponseTypes.invalid,
                    ErrorMessage = "All Fields Required"
                });
        }
        [HttpPost]
        public JsonResult Register(Register register)
        {
            if (ModelState.IsValid)
            {
                UserInfo userInfo = new UserInfo()
                {
                    Name = register.Name,
                    Address = register.Address,
                    Password = register.Password,
                    EmailId = register.EmailId.ToLower(),
                    LastName = register.LastName,
                    MobileNo = register.MobileNo
                };
                var userId = _userService.RegisterUser(userInfo);
                if (userId != 0)
                    return new JsonResult(new Response()
                    {
                        Status = Dal.Enum.ResponseTypes.ok,
                        Data =new {UserId = userId }
                    });
                else
                    return new JsonResult(new Response()
                    {
                        Status = Dal.Enum.ResponseTypes.invalid,
                        ErrorMessage = "User Already exists for this emailid or mobile no "
                    });
            }
            else
                return new JsonResult(new Response()
                {
                    Status = Dal.Enum.ResponseTypes.invalid,
                    ErrorMessage = "All Fields Required"
                });
        }
    }
}

using AutoMapperInjectionDemo.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AutoMapperInjectionDemo.Controllers
{
    [RoutePrefix("users")]
    public class UserController : ApiController
    {
        private IUserRepository _userRepo;

        public UserController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        [Route("all")]
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(_userRepo.GetAll());
        }
    }
}

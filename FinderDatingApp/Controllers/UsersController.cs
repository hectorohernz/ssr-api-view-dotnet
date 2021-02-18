using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinderDatingApp.models;
using FinderDatingApp.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinderDatingApp.Controllers
{
    [Route("/[controller]")]
    public class UsersController : ControllerBase
    {
        public UsersController(JsonFileUserService usersService)
        {
            this.UserService = usersService;
        }

        public JsonFileUserService UserService { get; }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return UserService.GetUsers();
        }
    }
}

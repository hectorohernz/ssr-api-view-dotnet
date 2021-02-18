using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinderDatingApp.models;
using FinderDatingApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FinderDatingApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;


        // Our Service
        public JsonFileUserService UserService;
        // Get List of users
        public IEnumerable<User> Users { get; private set;}

        public IndexModel(ILogger<IndexModel> logger, JsonFileUserService userService)
        {
            _logger = logger;
            UserService = userService;
        }

        public void OnGet()
        {
            Users = UserService.GetUsers();
        }
    }
}

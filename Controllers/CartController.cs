using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuthWithIdentity.Controllers
{
    public class CartController : Controller
    {
        private AppDbContext _dbContext;
        private UserManager<IdentityUser> _userManager;

        public CartController(UserManager<IdentityUser> userManager,AppDbContext dbcontext)
        {
            _dbContext = dbcontext;
            _userManager = userManager;
        }
        // GET: /<controller>/
        public async Task<IActionResult> IndexAsync()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            return View();
        }
    }
}

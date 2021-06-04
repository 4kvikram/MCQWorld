using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace MCQWorld.API.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string GetUserName()
        {

            var userName = User.FindFirstValue(ClaimTypes.Name); // will give the user's userName

            //ApplicationUser applicationUser = await UserManager.GetUserAsync(User);
            //   string userEmail = applicationUser?.Email; // will give the user's Email
            return userName;
        }
        public string GetUserId()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return userId;
        }
    }
}

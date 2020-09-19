using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Freebie.Models;

namespace Freebie.Controllers
{
    public class AuthController : Controller
    {
        private ApplicationContext db;
        public AuthController(ApplicationContext context)
        {
            db = context;
        }

        [Route("login")]
        public IActionResult Login()
        {
            return Content("login");
        }

        [Route("signup")]
        public IActionResult Signup()
        {
            return Content("signup");
        }

        [HttpPost]
        public async Task<IActionResult> Signup(User user)
        {
            db.Users.Add(user);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}

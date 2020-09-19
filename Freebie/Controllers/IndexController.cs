using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Freebie.Models;
using Freebie.Repositories;

namespace Freebie.Controllers
{
    public class IndexController : Controller
    {
        private ApplicationContext db;
        private EfCoreUserRepository repository;
        public IndexController(ApplicationContext context, EfCoreUserRepository efCoreUserRepository)
        {
            db = context;
            repository = efCoreUserRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await  repository.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            db.Users.Add(user);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}

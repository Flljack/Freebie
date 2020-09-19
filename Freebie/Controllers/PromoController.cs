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
    [Route("promo")]
    public class PromoController : Controller
    {
        private ApplicationContext db;
        public PromoController(ApplicationContext context)
        {
            db = context;
        }

        [Route("{id:int}")]
        public async Task<IActionResult> Index(int id)
        {

            return Content($" id={id}");
        }

        [Route("create")]
        public IActionResult Create()
        {
            return Content("create");
        }

        [Route("{id:int}/approve")]
        public IActionResult Approve(int id)
        {
            return Content($"approve promo id={id}");
        }

        [Route("{id:int}/delete")]
        public IActionResult Delete(int id)
        {
            return Content($"delete promo id={id}");
        }

        [Route("{id:int}/edit")]
        public IActionResult Edit(int id)
        {
            return Content($"edit promo id={id}");
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

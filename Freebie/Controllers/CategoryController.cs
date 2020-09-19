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
    [Route("category")]
    public class CategoryController : Controller
    {
        private ApplicationContext db;
        public CategoryController(ApplicationContext context)
        {
            db = context;
        }

        [Route("")]
        public IActionResult IndexAllCategory()
        {
            return Content("all category");
        }

        [Route("{id:int}")]
        public IActionResult Index(int id)
        {
            return Content($"select category id={id}");
        }

    }
}

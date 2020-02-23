using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApp.Models;
using WebApp.Data;
using WebApp.ViewModel;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {

        private ApplicationDbContext db;
        public HomeController(ApplicationDbContext context)
        {
            db = context;
        }



        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StartQuest()
        {
            return View();
        }
        public IActionResult Questionnaire()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Questionnaire(LostItem lostItem)
        {
            db.LostItems.Add(lostItem);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }



    }
}

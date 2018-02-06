using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RectangleChecker.Models;
using System;

namespace RectangleChecker.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
          return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Order_Management.Models;
using System.Diagnostics;

namespace Order_Management.Controllers
{
    public class MiscellaneousController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error404()
        {
            return View();
        }

        public IActionResult Error500()
        {
            return View();
        }
    }
}

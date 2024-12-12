using Microsoft.AspNetCore.Mvc;

namespace Order_Management.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}

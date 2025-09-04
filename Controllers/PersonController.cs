namespace MvcMovie.Controllers
{

    using Microsoft.AspNetCore.Mvc;
    using MvcMovie.Models;
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            ViewData["Message"] = "Your welcome message";

            return View();
        }
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            ViewBag.Message = "xin chào " + ps.FullName + " - " + ps.NamSinh;
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class HelloWordControllers : Controller
    {
        //GET: /HelloWord/
        public string Index()
        {
            return "this is my default action...";
        }
        //Get: /HelloWord/Welcome/
        public string Welcome()
        {
            return "this is the Welcome action method...";
        }
    }
}
using Cardvizite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cardvizite.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
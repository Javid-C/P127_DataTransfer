using Microsoft.AspNetCore.Mvc;
using P127_FrontToBackNew.Models;

namespace P127_FrontToBackNew.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            Heading model = new Heading
            {
                Id =1,
                Image = "avataaars.svg",
                Title = "START BOOTSTRAP ours",
                Desc = "Graphic Artist - Web Designer - Visual Studio"
            };
            return View(model);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}

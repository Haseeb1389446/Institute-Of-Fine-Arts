using Institute_Of_Fine_Arts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;

namespace Institute_Of_Fine_Arts.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _Context;
        private readonly IWebHostEnvironment _root;

        public HomeController(ApplicationDbContext context, IWebHostEnvironment root)
        {
            _Context = context;
            _root = root;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Competitions()
        {
            return View();
        }

        public IActionResult CreateCompetitions()
        {
            return View();
        }

        public IActionResult Exhibitions()
        {
            return View();
        }

        public IActionResult CreateExhibitions()
        {
            return View();
        }

        public IActionResult Awards()
        {
            return View();
        }

        public IActionResult CreateAwards()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Student()
        {
            return View();
        }

        public IActionResult SubmitPaintings()
        {
            return View();
        }

        public IActionResult ViewPaintings()
        {
            return View();
        }
        public IActionResult Staff()
        {
            return View();
        }

        public IActionResult Manager()
        {
            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }
    }
}

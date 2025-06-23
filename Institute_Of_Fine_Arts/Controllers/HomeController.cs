using Institute_Of_Fine_Arts.Models;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(ApplicationDbContext context, IWebHostEnvironment root, UserManager<IdentityUser> userManager)
        {
            _Context = context;
            _root = root;
            _userManager = userManager;
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
            TempData["awards"] = _Context.Awards.ToList();

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

        public async Task<IActionResult> CreateAwards()
        {
            var students = await _userManager.GetUsersInRoleAsync("student");
            ViewBag.students = students;

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

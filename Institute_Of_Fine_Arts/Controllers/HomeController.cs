using Institute_Of_Fine_Arts.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;
using System.Threading.Tasks;

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
            ViewBag.awards = _Context.Awards.ToList();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCompetitions(Competition competition, IFormFile competitionimage)
        {
            ViewBag.awards = await _Context.Awards.ToListAsync();

            if (ModelState.IsValid && competitionimage != null && competitionimage.Length > 0)
            {
                var rootPath = _root.WebRootPath;
                var location = Path.Combine(rootPath, "Uploads", "images");

                if (!Directory.Exists(location))
                {
                    Directory.CreateDirectory(location);
                }

                var fileLocation = Path.Combine(location, competitionimage.FileName);

                using (var stream = new FileStream(fileLocation, FileMode.Create))
                {
                    await competitionimage.CopyToAsync(stream);
                }

                competition.Banner = competitionimage.FileName;
                await _Context.Competitions.AddAsync(competition);
                await _Context.SaveChangesAsync();

                return RedirectToAction("staff");
            }

            return View();
        }

        public async Task<IActionResult> UpdateCompetitions(int id)
        {
            ViewBag.awards = await _Context.Awards.ToListAsync();

            var competition = await _Context.Competitions.FindAsync(id);
            HttpContext.Session.SetString("previouseimage", competition!.Banner!);

            return View(competition);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCompetitions(Competition competition, IFormFile competitionimage)
        {
            ViewBag.awards = await _Context.Awards.ToListAsync();

            if (competitionimage != null)
            {
                var rootPath = _root.WebRootPath;
                var location = Path.Combine(rootPath, "Uploads", "images");

                if (!Directory.Exists(location))
                {
                    Directory.CreateDirectory(location);
                }

                var previouseimage = HttpContext.Session.GetString("previouseimage");
                var oldfilelocaation = Path.Combine(location, previouseimage!);

                if (System.IO.File.Exists(oldfilelocaation))
                {
                    System.IO.File.Delete(oldfilelocaation);
                }

                var newfilelocation = Path.Combine(location, competitionimage.FileName!);

                using (var stream = new FileStream(newfilelocation, FileMode.Create))
                {
                    await competitionimage.CopyToAsync(stream);
                }

                competition.Banner = competitionimage.FileName;
                _Context.Entry(competition).State = EntityState.Modified;
                await _Context.SaveChangesAsync();

                return RedirectToAction("staff");
            }
            else
            {
                var previouseImage = HttpContext.Session.GetString("previouseimage");
                competition.Banner = previouseImage;

                _Context.Entry(competition).State = EntityState.Modified;
                await _Context.SaveChangesAsync();
                return RedirectToAction("staff");
            }
        }

        public async Task<IActionResult> DeleteCompetitions(int id)
        {
            var competition = await _Context.Competitions.FindAsync(id);
            _Context.Competitions.Remove(competition);
            await _Context.SaveChangesAsync();

            return RedirectToAction("staff");
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
            var awards = _Context.Awards.ToList();
            return View(awards);
        }

        public async Task<IActionResult> CreateAwards()
        {
            var students = await _userManager.GetUsersInRoleAsync("student");
            ViewBag.students = students;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAwards(Award award)
        {
            var students = await _userManager.GetUsersInRoleAsync("student");
            ViewBag.students = students;

            if (ModelState.IsValid)
            {
                await _Context.Awards.AddAsync(award);
                await _Context.SaveChangesAsync();

                return RedirectToAction("Staff");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAwards(int id)
        {
            var students = await _userManager.GetUsersInRoleAsync("student");
            ViewBag.students = students;

            var award = await _Context.Awards.FindAsync(id);
            return View(award);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAwards(Award award)
        {
            var students = await _userManager.GetUsersInRoleAsync("student");
            ViewBag.students = students;

            if (ModelState.IsValid)
            {
                _Context.Awards.Update(award);
                await _Context.SaveChangesAsync();

                return RedirectToAction("Staff");
            }

            return View();
        }

        public async Task<IActionResult> DeleteAwards(int id)
        {
            var award = await _Context.Awards.FindAsync(id);
            _Context.Awards.Remove(award);
            await _Context.SaveChangesAsync();

            return RedirectToAction("Staff");
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
        public async Task<IActionResult> Staff()
        {
            var model = new ModelsCollectionVeiewModel
            {
                Awards = await _Context.Awards.ToListAsync(),
                Competitions = await _Context.Competitions.Include(res => res.AwardDetails).ToListAsync()
            };

            return View(model);
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

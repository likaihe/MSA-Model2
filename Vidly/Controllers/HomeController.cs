using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var movielist = _context.Movies.Include(c => c.Genre).ToList();
            var homePageMovies = _context.HomepageMovies.SingleOrDefault(i => i.Id == 1);
            var viewModel = new HomePageViewMode
            {
                Movies = movielist,
                HomePageMovies = homePageMovies,
            };


            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Save(HomePageViewMode model)
        {
            var MovieIddb = _context.HomepageMovies.SingleOrDefault(m => m.Id==1);
            //change the movieId
           MovieIddb.Movie1 = model.HomePageMovies.Movie1;








            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
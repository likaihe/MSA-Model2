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
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
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
            return View(movielist);
        }

        public ActionResult Details(int Id)
        {
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == Id);
            return View(movie);
        }

        public ActionResult NewMovie()
        {
            var genre = _context.Genre;
            var viewModel = new MovieFormViewModel
            {
                Gener = genre
            };
            return View(viewModel);

        }

        public ActionResult Edit(int Id)
        {
            var movie = _context.Movies.Single(m => m.Id == Id);
            if (movie == null)
            {
                return HttpNotFound();
            }

            var viewModel = new MovieFormViewModel
            {
                Movies = movie,
                Gener = _context.Genre

            };

            return View("NewMovie", viewModel);
        }


        [HttpPost]
        public ActionResult Save(MovieFormViewModel movie)
        {


            movie.Movies.DateAdd = DateTime.Now;
            _context.Movies.Add(movie.Movies);

            //else
            //{
            //    var customerDb = _context.Customers.Single(c => c.Id == movie.Id);

            //}
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }


    }


}
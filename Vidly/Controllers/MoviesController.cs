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
                Gener = genre,
                Title = "New Movie"
            };
            return View("MovieForm", viewModel);

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
                Gener = _context.Genre,
                Title = "Edit Movie"
            };

            return View("MovieForm", viewModel);
        }


        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Save(MovieFormViewModel movie)
        {


            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel
                {
                    Movies = movie.Movies,
                    Gener = _context.Genre
                };

                return View("MovieForm", viewModel);
            }

            if (movie.Movies.Id == 0)
            {
                movie.Movies.DateAdd = DateTime.Now;
                _context.Movies.Add(movie.Movies);

            }
            else
            {
                var Moviedb = _context.Movies.Single(c => c.Id == movie.Movies.Id);

                Moviedb.Name = movie.Movies.Name;
                Moviedb.ReleaseDate = movie.Movies.ReleaseDate;
                Moviedb.GenreId = movie.Movies.GenreId;
                Moviedb.NumberInStock = movie.Movies.NumberInStock;

            }

           



            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }


    }


}
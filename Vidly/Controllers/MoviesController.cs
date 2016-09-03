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
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c =>c.Id == Id);
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


    }
   

}
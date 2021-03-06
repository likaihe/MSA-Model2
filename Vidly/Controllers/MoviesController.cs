﻿using System;
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
            if (User.IsInRole("Manager"))
                return View("Manager");
            else {
                var movielist = _context.Movies.Include(c => c.Genre).ToList();
                return View(movielist);
            }
            
        }

        public ActionResult Details(int Id)
        {
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == Id);
            var comment = _context.Comments.Where(c => c.MoviesId == Id).ToList();
            //var user = _context.
            var viewModel = new MovieFormViewModel
            {
                Movies = movie,
                Gener = _context.Genre,
                Comments = comment,
               
            };

            
            return View(viewModel);
        }

        public ActionResult NewMovie()
        {
            var genre = _context.Genre;
            var viewModel = new MovieFormViewModel
            {
                Gener = genre,
                Title = "New Movie"
            };
            return View(viewModel);

        }

        public ActionResult Edit(int Id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == Id);
            var comment = _context.Comments.Where(m => m.MoviesId == Id).ToList();
            var newcomment = _context.Comments.SingleOrDefault(m => m.Id == 0);


            if (movie == null)
            {
                return HttpNotFound();
            }

            var viewModel = new MovieFormViewModel
            {
                Movies = movie,
                Gener = _context.Genre,
                Comments = comment,
                NewComment = newcomment,
                Title = "Edit Movie"
            };

            return View(viewModel);
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

                return View("NewMovie", viewModel);
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
                Moviedb.PicUrl = movie.Movies.PicUrl;

            }

           



            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult SubmitComment(MovieFormViewModel movie)
        {
            int movieId = movie.NewComment.MoviesId;

            //if (!ModelState.IsValid)
            //{
            //    var viewModel = new MovieFormViewModel
            //    {
            //        Movies = movie.Movies,
            //        Gener = _context.Genre,
            //        Comments = movie.Comments
            //    };

            //    return View("Details",new { Id = movieId });
            //}

            _context.Comments.Add(movie.NewComment);
            _context.SaveChanges();
            return RedirectToAction("Details", "Movies",new { Id = movieId });
        }

    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        public ActionResult Index()
        {

            var movielist = new Movies()
            {
                Movielist = GetMovies()
            };

            return View(movielist);
        }

        private List<Movie> GetMovies()
        {
            return new List<Movie>
             {
                 new Movie { Id = 1, Name = "Shrek" },
                 new Movie { Id = 2, Name = "Wall-e" }
             };
        }

    }
   

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class HomePageViewMode
    {
        public List<Movies> Movies { set; get; }
        public HomePageMovies HomePageMovies { set; get; }
    }
   
   
}
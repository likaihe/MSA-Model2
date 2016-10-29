using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Vidly.Models
{
    public class HomePageMovies
    {
        public int Id { get; set; }
        public int Movie1 { set; get; }
        public int Movie2 { set; get; }
        public int Movie3 { set; get; }
        public int Movie4 { set; get; }
        public int Movie5 { set; get; }
    }
}
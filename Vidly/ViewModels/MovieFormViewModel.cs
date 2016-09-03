using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public Movies Movies { set; get; }
        public IEnumerable<Genre> Gener { set; get; }
    }
}
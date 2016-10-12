﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdd { get; set; }
        public int NumberInStock { get; set; }
        public string PicUrl { get; set; }

        public Genre Genre { get; set; }
        [Required]
        public int GenreId { get; set; }
    }

    
}
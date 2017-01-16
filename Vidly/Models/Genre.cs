﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<Movie> Movies { get; set; }

        public Genre()
        {
            Movies = new List<Movie>();
        }
    }
}
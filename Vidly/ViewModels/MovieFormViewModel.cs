using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required(ErrorMessage = "Name of the movie is required.")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleasedDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Required]
        [Range(minimum: 1, maximum: 20, ErrorMessage = "Number in stock should be between {1} and {2}.")]
        public int? NumberInStock { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public int? GenreId { get; set; }

        public string Title
        {
            get {
                return (Id.HasValue) ? "Edit Movie": "New Movie";
            }
        }

        public MovieFormViewModel()
        {
            this.Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleasedDate = movie.ReleasedDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}
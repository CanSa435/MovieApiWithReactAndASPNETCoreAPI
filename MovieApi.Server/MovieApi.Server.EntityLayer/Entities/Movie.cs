using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Server.EntityLayer.Entities
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string? MovieTitle { get; set; }
        public string? OriginalTitle { get; set; }
        public int ReleaseYear { get; set; }
        public string? PosterImageUrl { get; set; }
        public string? ReleaseDate { get; set; }
        public string? MovieSecond { get; set; }    
        public string? MovieReview { get; set; }
        public int DirectorId { get; set; }
        public Director? Director { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<Actor> Actors { get; set; } = new List<Actor>();
       
    }
}

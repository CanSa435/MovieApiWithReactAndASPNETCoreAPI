using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Server.Dtos.MovieDtos
{
    public class MovieDetailDto
    {
        public int MovieId { get; set; }
        public string? MovieTitle { get; set; }
        public string? OriginalTitle { get; set; }
        public int ReleaseYear { get; set; }
        public string? ReleaseDate { get; set; }
        public string? PosterImageUrl { get; set; }
        public string? MovieSecond { get; set; }
        public string? MovieReview { get; set; }
        public string? DirectorFullName { get; set; }
        public List<string> Categories { get; set; } = new List<string>();
        public List<string> Actors { get; set; } = new List<string>();

    }
}

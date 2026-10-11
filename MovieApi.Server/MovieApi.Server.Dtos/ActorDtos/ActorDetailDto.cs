using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Server.Dtos.ActorDtos
{
    public class ActorDetailDto
    {
        public int ActorId { get; set; }
        public string? ActorFullName { get; set; }
        public string? BornDate { get; set; }
        public string? ActorImage { get; set; }
        public string? ActorBiography { get; set; }
        public string? MovieTitle { get; set; }
        public string? MoviePosterImage { get; set; }
    }
}

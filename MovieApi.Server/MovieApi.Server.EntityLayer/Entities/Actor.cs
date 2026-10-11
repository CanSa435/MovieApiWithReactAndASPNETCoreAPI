using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Server.EntityLayer.Entities
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string? ActorFullName { get; set; }
        public string? BornDate { get; set; }
         public string? ActorImage { get; set; }
        public string? ActorBiography { get; set; }
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }
    }
}

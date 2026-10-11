using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Server.EntityLayer.Entities
{
    public class Director
    {
        public int DirectorID { get; set; }
        public string? DirectorFullName { get; set; }
        public string? DirectorBornDate { get; set; }
        public string? DirectorOverview { get; set; }
        public string? DirectorImage { get; set; }
        public string? DirectorBiography { get; set; }
        public List<Movie> Movies { get; set; } = new List<Movie>();
    }
}

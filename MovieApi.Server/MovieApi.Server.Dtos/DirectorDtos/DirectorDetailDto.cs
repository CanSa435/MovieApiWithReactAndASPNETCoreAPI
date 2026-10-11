using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Server.Dtos.DirectorDtos
{
    public class DirectorDetailDto
    {
        public int DirectorID { get; set; }
        public string? DirectorFullName { get; set; }
        public string? DirectorBornDate { get; set; }
        public string? DirectorOverview { get; set; }
        public string? DirectorImage { get; set; }
        public string? DirectorBiography { get; set; }
        public List<string> Movies { get; set; } = new List<string>();
    }
}

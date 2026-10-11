using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Server.EntityLayer.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }
    }
}

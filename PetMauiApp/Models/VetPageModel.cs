using System;
using System.Collections.Generic;
using System.Text;

namespace PetMauiApp.Models
{
    public class VetPageModel
    {
        public class Vet
        {
            public string? Name { get; set; }
            public string? Category { get; set; }
            public string? Specialization { get; set; }
            public string? Rating { get; set; }
            public string? Reviews { get; set; }
            public string? Experience { get; set; }
            public string? Distance { get; set; }
            public string? Price { get; set; }
            public string? Schedule { get; set; }
            public string? ImageUrl { get; set; }
            public string? Status { get; set; }
        }

        public class NearbyPlace
        {
            public string? Name { get; set; }
            public string? Category { get; set; }
            public string? Specialization { get; set; }
            public string? Rating { get; set; }
            public string? Reviews { get; set; }
            public string? Experience { get; set; }
            public string? Distance { get; set; }
            public string? Schedule { get; set; }
            public string? ImageUrl { get; set; }
            public string? Status { get; set; }
        }
    }
}
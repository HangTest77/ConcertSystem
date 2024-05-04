using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Drawing;

namespace ConcertSystem.Models
{
    public class Admin
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        [DisplayName("Concert")]
        public String name { get; set; }

        [StringLength(50, MinimumLength = 1)]
        [DisplayName("Artist")]
        public String artist { get; set; }

        [StringLength(50, MinimumLength = 1)]
        [DisplayName("Concert Description")]
        public String description { get; set; }

        [DisplayName("Date")]
        public String dateTime { get; set; }

        [DisplayName("Time")]
        public String time { get; set; }

        [DisplayName("Language")]
        public String language { get; set; }

        [DisplayName("Venue")]
        public String venue { get; set; }

        [DisplayName("Trending?")]
        public String trending { get; set; }

        [DisplayName("Ticket Price")]
        public String price { get; set; }

        //[DisplayName("Concert Poster")]
        //public byte[] PosterData { get; set; } // Byte array to store image data

        //[DisplayName("Poster Content Type")]
        //public string PosterContentType { get; set; } // Store image content type

        //[DisplayName("Poster File")]
        //public IFormFile ImageFile { get; set; }



        public Admin() { }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

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

        [DisplayName("Date")]
        public String dateTime { get; set; }

        [DisplayName("Time")]
        public String time { get; set; }

        [DisplayName("Language")]
        public String language { get; set; }

        [DisplayName("Venue")]
        public String venue { get; set; }

        [DisplayName("Trendings")]
        public String trending { get; set; }

        public Admin() { }
    }
}

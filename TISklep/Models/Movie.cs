using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TISklep.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required(ErrorMessage = "You didn't enter the title")]
        public string Title { get; set; }

        public string Director { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public decimal Price { get; set; }

        public DateTime? ProductionDate { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Plant_Life.Models
{
    public class Plant
    {
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }

        public int Id { get; set; }
        [Required]
        [Display(Name = "Plant Name")]
        public string PlantName { get; set; }
        [Required]
        [Display(Name = "Plant Care")]
        public string PlantCare { get; set; }
        public int Quantity { get; set; }
        public string? Image { get; set; }

    }
}

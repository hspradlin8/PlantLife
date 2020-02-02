using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plant_Life.Models
{
    public class Plant
    {
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }

        public int Id { get; set; }

        public string PlantName { get; set; }
        public string PlantCare { get; set; }
        public int Quantity { get; set; }
        public string? Image { get; set; }

    }
}

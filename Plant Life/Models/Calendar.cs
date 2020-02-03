using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plant_Life.Models
{
    public class Calendar
    {
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }
        public int Id { get; set; }
        public int PlantId { get; set; }
        public int UserPlantId { get; set; }
      

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}

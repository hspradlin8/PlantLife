using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plant_Life.Models.ViewModel
{
    public class PlantIndexViewModel
    {
       public int Id { get; set; }
        public ICollection<Plant> Plants { get; set; }
        public ICollection<DefaultPlantUser> DefaultPlantUsers { get; set; }
        public ICollection<Event> Events { get; set; }
      
    }
}

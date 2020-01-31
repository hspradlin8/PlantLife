using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plant_Life.Models
{
    public class PlantCalendar
    {
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }
        public int Id { get; set; }
        public int PlantId { get; set; }
        public int CalendarId { get; set; }
    }
}

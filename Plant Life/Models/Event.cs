using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plant_Life.Models
{
    public class Event
    {
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }
        public int EventId { get; set; }
        public string EventName { get; set; }
        public int UserId { get; set; }
        public int PlantId { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string StartDateString { get { return StartDate.Date.ToString(); } }
        public string EndDateString { get { return EndDate.Date.ToString(); } }

    }
}

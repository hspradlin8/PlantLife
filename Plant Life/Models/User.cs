using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plant_Life.Models
{
    public class User
    {
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plant_Life.Models.DefaultPlantUserViewModel
{
    public class DefaultPlantUserViewModels
    {
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }
        public int Id { get; set; }

        public int DefaultPlantId { get; set; }
        public string Image { get; set; }
        public Plant Plant { get; set; }
    }
}

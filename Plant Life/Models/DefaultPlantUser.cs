using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Plant_Life.Models
{
    public class DefaultPlantUser
    {
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }
        public int Id { get; set; }
     
        public int DefaultPlantId { get; set; }
        public string Image { get; set; }
     
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }
        public DefaultPlant DefaultPlant { get; set; }
    }
}

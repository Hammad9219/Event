using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class Events
    {
        public string Title { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Location { get; set; }

        [Key]
        [Required]
        [DataType(DataType.Time)]
        public DateTime Starttime { get; set; }
        public string Type { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string Invitations { get; set; }

        
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class EditModel 
    {
        [Required]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public string Location { get; set; }

        [DataType(DataType.Time)]
        [Required]
        [Display(Name = "Start Time")]
        public DateTime Starttime { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Details { get; set; }

        [Required]
        [Display(Name = "Invite by Email")]
        public string Invitations { get; set; }
    }
}

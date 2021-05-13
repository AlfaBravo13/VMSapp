using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMSapp_BlazorServer.Models
{
    public class NewExperimentComponentModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "The Title is too long.")]
        public string Title { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "The Requirement is too long.")]
        public string Requirement { get; set; }

        [StringLength(1000, ErrorMessage = "The Description is too long.")]
        public string Description { get; set; }
    }
}

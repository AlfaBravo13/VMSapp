using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WMSapp_BlazorServer.Models
{
    public class NewVehicleComponentModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "The Title is too long.")]
        public string Title { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "The Vehicle Number is too long")]
        public string VehicleNumber { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "The Build Number is too long")]
        public string BuildNumber { get; set; }

        public string Stage { get; set; }
    }
}

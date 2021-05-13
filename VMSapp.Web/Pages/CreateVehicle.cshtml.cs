using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VMSLibrary.Data;
using VMSLibrary.Models;

namespace VMSapp.Web.Pages
{
    public class CreateVehicleModel : PageModel
    {
        private readonly IDatabaseData db;
        [BindProperty]
        public VehicleModel Vehicle { get; set; }

        public CreateVehicleModel(IDatabaseData db)
        {
            this.db = db;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            db.AddVehicle(Vehicle.Title, Vehicle.Number, Vehicle.BuildNumber);
            return RedirectToPage("/Dashboard");
        }
    }
}

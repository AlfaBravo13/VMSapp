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
    public class ViewVehicleModel : PageModel
    {
        private readonly IDatabaseData db;

        [BindProperty(SupportsGet = true)]
        public int ActiveId { get; set; }

        public VehicleModel Vehicle { get; set; }
        public List<ExperimentModel> AllVehicleExperiments { get; set; }

        public ViewVehicleModel(IDatabaseData db)
        {
            this.db = db;
        }
        public void OnGet()
        {
            Vehicle = db.GetSelectedVehicle(ActiveId);
            AllVehicleExperiments = db.GetVehicleExperiments(ActiveId);
        }

        public IActionResult OnPostPromote()
        {
            db.PromoteVehicleStage(ActiveId);
            return RedirectToPage(new { ActiveId = ActiveId });
        }

        public IActionResult OnPostDemote()
        {
            db.DemoteVehicleStage(ActiveId);
            return RedirectToPage(new { ActiveId = ActiveId });
        }
    }
}

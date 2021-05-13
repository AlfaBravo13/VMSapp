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
    public class CreateExperimentModel : PageModel
    {
        private readonly IDatabaseData db;
        [BindProperty(SupportsGet = true)]
        public int ActiveId { get; set; }
        [BindProperty]
        public ExperimentModel Experiment { get; set; }

        public CreateExperimentModel(IDatabaseData db)
        {
            this.db = db;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            db.AddExperiment(Experiment.Title, Experiment.Requirement, Experiment.Description, ActiveId);
            return RedirectToPage("/ViewVehicle", new { ActiveId = ActiveId });
        }
    }
}

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
    public class ViewExperimentModel : PageModel
    {
        private readonly IDatabaseData db;
        [BindProperty(SupportsGet = true)]
        public int ActiveId { get; set; }
        public ExperimentModel Experiment { get; set; }

        public ViewExperimentModel(IDatabaseData db)
        {
            this.db = db;
        }
        public void OnGet()
        {
            Experiment = db.GetSelectedExperiment(ActiveId);
        }
    }
}

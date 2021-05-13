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
    public class DashboardModel : PageModel
    {
        private readonly IDatabaseData db;
        public List<VehicleModel> AllVehicles { get; set; }

        public DashboardModel(IDatabaseData db)
        {
            this.db = db;
        }

        public void OnGet()
        {
            AllVehicles = db.GetAllVehicles();
        }
    }
}
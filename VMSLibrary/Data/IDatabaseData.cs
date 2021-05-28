using System.Collections.Generic;
using System.Threading.Tasks;
using VMSLibrary.Models;

namespace VMSLibrary.Data
{
    public interface IDatabaseData
    {
        Task<List<VehicleModel>> GetAllVehicles();
        Task<VehicleModel> GetSelectedVehicle(int activeId);
        Task<List<ExperimentModel>> GetVehicleExperiments(int activeId);
        Task<ExperimentModel> GetSelectedExperiment(int activeId);
        Task AddVehicle(string title, string number, string buildnumber);
        Task AddExperiment(string title, string requirement, string description, int vehicleId);
        Task PromoteVehicleStage(int activeId);
        Task DemoteVehicleStage(int activeId);
    }
}
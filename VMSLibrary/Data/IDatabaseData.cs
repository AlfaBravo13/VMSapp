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
        Task DeleteVehicle(int id);
        Task UpdateVehicle(int id, string title, string number, string buildNumber);
        Task AddExperiment(string title, string requirement, string description, int vehicleId);
        Task DeleteExperiment(int vehicleId, int experimentId);
        Task UpdateExperiment(int id, string title, string requirement, string description);
        Task PromoteVehicleStage(int activeId);
        Task DemoteVehicleStage(int activeId);
    }
}
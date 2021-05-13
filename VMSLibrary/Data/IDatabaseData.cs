using System.Collections.Generic;
using VMSLibrary.Models;

namespace VMSLibrary.Data
{
    public interface IDatabaseData
    {
        void AddExperiment(string title, string requirement, string description, int vehicleId);
        void AddVehicle(string title, string number, string buildnumber);
        List<VehicleModel> GetAllVehicles();
        ExperimentModel GetSelectedExperiment(int activeId);
        VehicleModel GetSelectedVehicle(int activeId);
        List<ExperimentModel> GetVehicleExperiments(int activeId);
        void PromoteVehicleStage(int activeId);
        void DemoteVehicleStage(int activeId);
    }
}
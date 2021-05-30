using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMSLibrary.Databases;
using VMSLibrary.Models;

namespace VMSLibrary.Data
{
    public class MSSqlData : IDatabaseData
    {
        private readonly IMSSqlDataAccess db;
        private const string connectionStringName = "SqlDb";

        public MSSqlData(IMSSqlDataAccess db)
        {
            this.db = db;
        }

        public async Task<List<VehicleModel>> GetAllVehicles()
        {

            var vehicle = await db.LoadDataAsync<VehicleModel, dynamic>("dbo.spVehicles_GetAllVehicles",
                                                                        new { },
                                                                        connectionStringName);

            return vehicle.ToList<VehicleModel>();
        }

        public async Task<VehicleModel> GetSelectedVehicle(int activeId)
        {
            var vehicle = await db.LoadDataAsync<VehicleModel, dynamic>("dbo.spVehicles_GetSelectedVehicle",
                                                                        new { activeId },
                                                                        connectionStringName);

            return vehicle.FirstOrDefault();
        }

        public async Task<List<ExperimentModel>> GetVehicleExperiments(int activeId)
        {
            return await db.LoadDataAsync<ExperimentModel, dynamic>("dbo.spExperiments_GetVehicleExperiments",
                                                                    new { activeId },
                                                                    connectionStringName);
        }

        public async Task<ExperimentModel> GetSelectedExperiment(int activeId)
        {
            var experiment = await db.LoadDataAsync<ExperimentModel, dynamic>("dbo.spExperiments_GetSelectedExperiment",
                                                                              new { activeId },
                                                                              connectionStringName);

            return experiment.FirstOrDefault();
        }

        public async Task AddVehicle(string title, string number, string buildnumber)
        {
            await db.SaveDataAsync("dbo.spVehicles_AddVehicle",
                                   new { title, number, buildnumber },
                                   connectionStringName);
        }

        public async Task DeleteVehicle(int id)
        {
            await db.SaveDataAsync("dbo.spVehicles_DeleteVehicle",
                                   new { id },
                                   connectionStringName);
        }

        public async Task UpdateVehicle(int id, string title, string number, string buildNumber)
        {
            await db.SaveDataAsync("dbo.spVehicles_UpdateVehicle",
                                   new { Id = id, Title = title, Number = number, BuildNumber = buildNumber },
                                   connectionStringName);
        }

        public async Task AddExperiment(string title, string requirement, string description, int vehicleId)
        {
            await db.SaveDataAsync("dbo.spExperiments_AddExperiment",
                                   new { title, requirement, description, vehicleId },
                                   connectionStringName);

        }

        public async Task DeleteExperiment(int vehicleId, int experimentId)
        {
            await db.SaveDataAsync("dbo.spExperiments_DeleteExperiment",
                                   new { vehicleId, experimentId },
                                   connectionStringName);
        }

        public async Task UpdateExperiment(int id, string title, string requirement, string description)
        {
            await db.SaveDataAsync("dbo.sp_Experiments_UpdateExperiment",
                        new { id, title, requirement, description },
                        connectionStringName);
        }

        public async Task PromoteVehicleStage(int activeId)
        {
            await db.SaveDataAsync("dbo.spVehicles_PromoteVehicleStage",
                              new { activeId },
                              connectionStringName);
        }

        public async Task DemoteVehicleStage(int activeId)
        {
            await db.SaveDataAsync("dbo.spVehicles_DemoteVehicleStage",
                        new { activeId },
                        connectionStringName);
        }

       
    }
}

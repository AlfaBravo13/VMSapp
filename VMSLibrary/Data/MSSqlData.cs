using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public async Task AddExperiment(string title, string requirement, string description, int vehicleId)
        {
            await db.SaveDataAsync("dbo.spExperiments_AddExperiment",
                                   new { title, requirement, description, vehicleId },
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

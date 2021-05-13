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

        public List<VehicleModel> GetAllVehicles()
        {
            return db.LoadData<VehicleModel, dynamic>("dbo.spVehicles_GetAllVehicles",
                                                      new { },
                                                      connectionStringName,
                                                      true);
        }

        public VehicleModel GetSelectedVehicle(int activeId)
        {
            return db.LoadData<VehicleModel, dynamic>("dbo.spVehicles_GetSelectedVehicle",
                                                      new { activeId },
                                                      connectionStringName,
                                                      true).First();
        }

        public List<ExperimentModel> GetVehicleExperiments(int activeId)
        {
            return db.LoadData<ExperimentModel, dynamic>("dbo.spExperiments_GetVehicleExperiments",
                                                         new { activeId },
                                                         connectionStringName,
                                                         true);
        }

        public ExperimentModel GetSelectedExperiment(int activeId)
        {
            return db.LoadData<ExperimentModel, dynamic>("dbo.spExperiments_GetSelectedExperiment",
                                                         new { activeId },
                                                         connectionStringName,
                                                         true).First();
        }

        public void AddVehicle(string title, string number, string buildnumber)
        {
            db.SaveData("dbo.spVehicles_AddVehicle",
                        new { title, number, buildnumber },
                        connectionStringName,
                        true);
        }

        public void AddExperiment(string title, string requirement, string description, int vehicleId)
        {
            db.SaveData("dbo.spExperiments_AddExperiment",
                        new { title, requirement, description, vehicleId},
                        connectionStringName,
                        true);

        }

        public void PromoteVehicleStage(int activeId)
        {
            db.SaveData("dbo.spVehicles_PromoteVehicleStage",
                        new { activeId },
                        connectionStringName,
                        true);
        }

        public void DemoteVehicleStage(int activeId)
        {
            db.SaveData("dbo.spVehicles_DemoteVehicleStage",
                        new { activeId },
                        connectionStringName,
                        true);
        }
    }
}

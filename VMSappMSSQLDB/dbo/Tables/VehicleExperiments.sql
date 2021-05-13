CREATE TABLE [dbo].[VehicleExperiments]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [VehicleId] INT NOT NULL, 
    [ExperimentId] INT NOT NULL, 
    CONSTRAINT [FK_VehicleExperiments_Vehicles] FOREIGN KEY (VehicleId) REFERENCES Vehicles(Id), 
    CONSTRAINT [FK_VehicleExperiments_Experiments] FOREIGN KEY (ExperimentId) REFERENCES Experiments(Id)
)

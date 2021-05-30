CREATE TABLE [dbo].[VehicleExperiments] (
    [Id]           INT IDENTITY (1, 1) NOT NULL,
    [VehicleId]    INT NOT NULL,
    [ExperimentId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_VehicleExperiments_Vehicles] 
		FOREIGN KEY ([VehicleId])
		REFERENCES [dbo].[Vehicles] ([Id]),
    CONSTRAINT [FK_VehicleExperiments_Experiments]
		FOREIGN KEY ([ExperimentId])
		REFERENCES [dbo].[Experiments] ([Id])
        ON DELETE CASCADE
);


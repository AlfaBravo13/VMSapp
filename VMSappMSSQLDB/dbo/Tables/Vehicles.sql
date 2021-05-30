CREATE TABLE [dbo].[Vehicles]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(200) NULL, 
    [Number] VARCHAR(10) NULL, 
    [BuildNumber] VARCHAR(10) NULL, 
    [StageId] INT NOT NULL, 
    CONSTRAINT [FK_Vehicles_VehicleStages] FOREIGN KEY (StageId) REFERENCES [VehicleStages](Id)
)

CREATE TABLE [dbo].[Vehicles]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(200) NOT NULL, 
    [Number] VARCHAR(10) NOT NULL, 
    [BuildNumber] VARCHAR(10) NOT NULL, 
    [StageId] INT NOT NULL, 
    CONSTRAINT [FK_Vehicles_VehicleStages] FOREIGN KEY (StageId) REFERENCES [VehicleStages](Id)
)

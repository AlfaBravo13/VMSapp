CREATE PROCEDURE [dbo].[spExperiments_AddExperiment]

@title nvarchar(200),
@requirement nvarchar(200),
@description nvarchar(1000),
@vehicleId int

AS
begin
	set nocount on;

	insert into dbo.Experiments (Title, Requirement, Description)
	values (@title, @requirement, @description);

	insert into dbo.VehicleExperiments (ExperimentId, VehicleId)
	values (SCOPE_IDENTITY(), @vehicleId);

end
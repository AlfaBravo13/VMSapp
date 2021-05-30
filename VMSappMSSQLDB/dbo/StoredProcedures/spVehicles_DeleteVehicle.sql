CREATE PROCEDURE [dbo].[spVehicles_DeleteVehicle]
	@id int
AS
begin
	set nocount on;

	delete from dbo.Experiments
	where Id in (select ExperimentId from dbo.VehicleExperiments where VehicleId = @id)

	delete from dbo.Vehicles
	where Id=@id;

end
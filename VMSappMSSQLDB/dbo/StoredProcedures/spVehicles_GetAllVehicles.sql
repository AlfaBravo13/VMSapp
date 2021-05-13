CREATE PROCEDURE [dbo].[spVehicles_GetAllVehicles]

AS
begin
	set nocount on;

	select [v].[Id], [v].[Title], [v].[Number], [v].[BuildNumber], [vs].[Title] as Stage
	from dbo.Vehicles v
	inner join dbo.VehicleStages vs on vs.Id = v.StageId;
end
CREATE PROCEDURE [dbo].[spExperiments_GetVehicleExperiments]
	@activeId int
AS
begin
	set nocount on;

	select [e].[Id], [e].[Title], [e].[Requirement], [e].[Description]
	from dbo.Experiments e
	inner join dbo.VehicleExperiments ve on e.Id = ve.ExperimentId
	where ve.VehicleId = @activeId;

end
CREATE PROCEDURE [dbo].[spVehicles_PromoteVehicleStage]
	@activeId int
AS

begin
	set nocount on;

	update dbo.Vehicles
	set StageId = StageId + 1
	where Id = @activeId;

end
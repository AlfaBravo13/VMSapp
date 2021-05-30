CREATE PROCEDURE [dbo].[spExperiments_DeleteExperiment]
	@vehicleId int,
	@experimentId int
AS
begin
	set nocount on;

	delete from dbo.Experiments
	where Id = @experimentId;
	
end
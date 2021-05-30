CREATE PROCEDURE [dbo].[sp_Experiments_UpdateExperiment]
	@id int,
	@title nvarchar(200),
	@requirement nvarchar(200),
	@description nvarchar(1000)
AS
begin
	set nocount on;

	update dbo.Experiments
	set Title = @title,
		Requirement = @requirement,
		[Description] = @description
	where Id = @id
end
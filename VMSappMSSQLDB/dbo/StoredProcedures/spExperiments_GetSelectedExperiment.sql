CREATE PROCEDURE [dbo].[spExperiments_GetSelectedExperiment]
	@activeId int
AS
begin
	set nocount on;

	select [Id], [Title], [Requirement], [Description]
	from dbo.Experiments e
	where e.Id = @activeId;
end
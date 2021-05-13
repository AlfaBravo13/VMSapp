CREATE PROCEDURE [dbo].[spVehicles_AddVehicle]

	@title nvarchar(200),
	@number varchar(10),
	@buildNumber varchar(10)

AS
begin
	set nocount on;

	insert into dbo.Vehicles(Title, Number, BuildNumber, StageId)
	values (@title, @number, @buildNumber, 1);
end
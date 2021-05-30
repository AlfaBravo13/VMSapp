CREATE PROCEDURE [dbo].[spVehicles_UpdateVehicle]
	@Id int,
	@Title nvarchar(200),
	@Number varchar(10),
	@BuildNumber varchar(10)
AS
begin
	set nocount on;

	update dbo.Vehicles
	set Title = @Title,
		Number = @Number,
		BuildNumber = @BuildNumber
	where Id = @Id;
end
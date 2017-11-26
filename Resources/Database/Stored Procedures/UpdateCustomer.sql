CREATE PROCEDURE UpdateCustomer
	@ID int, @Name text, @Latitude decimal(8,6), @Longitude decimal(9,6)
AS
BEGIN
	UPDATE Customer SET Name = @Name, Latitude = @Latitude, Longitude = @Longitude
	WHERE ID = @ID   
END
GO


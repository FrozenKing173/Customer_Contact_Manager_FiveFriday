
CREATE PROCEDURE AddCustomer
	@Name text, @Latitude decimal(8,6), @Longitude decimal(9,6)
AS
BEGIN
	INSERT INTO Customer (Name, Latitude, Longitude)
	VALUES(@Name, @Latitude, @Longitude)
   
END
GO

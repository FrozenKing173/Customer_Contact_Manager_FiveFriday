CREATE PROCEDURE AddCustomerContacts
	@Name text, @Email varchar(320), @ContactNumber varchar(50), @CustomerID int
AS
BEGIN
	INSERT INTO Customer_Contacts (Name, Email, ContactNumber, CustomerID)
	VALUES (@Name, @Email, @ContactNumber, @CustomerID)
END
GO

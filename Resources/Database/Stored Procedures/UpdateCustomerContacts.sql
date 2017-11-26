
CREATE PROCEDURE UpdateCustomerContacts
	@ID int,@Name text, @Email varchar(320), @ContactNumber varchar(50)
AS
BEGIN
	UPDATE Customer_Contacts SET Name = @Name, Email = @Email, ContactNumber = @ContactNumber
	WHERE ID = @ID	
END
GO

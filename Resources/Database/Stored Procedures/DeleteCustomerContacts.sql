USE [Customer Contact Manager FiveFriday]
GO

CREATE PROCEDURE [dbo].[sp_DeleteCustomerContacts]
@ID int
AS
BEGIN
	DELETE FROM Customer_Contacts WHERE ID = @ID
END
GO
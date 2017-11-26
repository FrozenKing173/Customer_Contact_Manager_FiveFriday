USE [Customer Contact Manager FiveFriday]
GO
CREATE PROCEDURE [dbo].[sp_SelectAllCustomerContacts]
	@CustomerID int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM Customer_Contacts WHERE CustomerID = @CustomerID
END
GO


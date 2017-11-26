USE [Customer Contact Manager FiveFriday]
GO
CREATE PROCEDURE [dbo].[sp_SelectCustomers]
	@ID int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM Customer WHERE ID = @ID
END
GO

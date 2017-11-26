USE [Customer Contact Manager FiveFriday]
GO
CREATE PROCEDURE [dbo].[sp_SelectAllCustomers]
	
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM Customer  
END
GO

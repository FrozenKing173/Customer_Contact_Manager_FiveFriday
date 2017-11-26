USE [Customer Contact Manager FiveFriday]
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteCustomer]    Script Date: 11/27/2017 1:15:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[sp_DeleteCustomer]
@ID int
AS
BEGIN
	DELETE FROM Customer_Contacts WHERE customerID = @ID
	DELETE FROM Customer WHERE ID = @ID
END

CREATE PROCEDURE [dbo].[Payment_Delete]
@ID int
AS
DELETE from [dbo].[Payment]
WHERE Id = @ID
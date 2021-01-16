CREATE PROCEDURE [dbo].[Payment_Delete]
@Id int
AS
DELETE from [dbo].[Payment]
WHERE Id = @Id
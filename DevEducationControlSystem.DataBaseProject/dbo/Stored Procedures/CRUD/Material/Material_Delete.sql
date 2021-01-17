CREATE PROCEDURE [dbo].[Material_Delete]
@Id int
AS
DELETE from dbo.Material
WHERE Id = @Id

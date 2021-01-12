CREATE PROCEDURE [dbo].[Material_Delete]
@Id int
AS
DELETE Material
WHERE ID = @Id

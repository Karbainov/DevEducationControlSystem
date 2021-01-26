CREATE PROCEDURE [dbo].[Resource_Update]
	@Id int,
	@Links NVARCHAR(1000),
    @Images NVARCHAR(1000)
AS
UPDATE [dbo].[Resource] 
SET
Links = @Links, 
Images = @Images 
WHERE [dbo].[Resource].Id = @Id
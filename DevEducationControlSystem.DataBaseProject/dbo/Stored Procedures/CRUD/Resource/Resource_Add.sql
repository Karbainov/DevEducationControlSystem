  CREATE PROCEDURE [dbo].[Resource_Add]
    @Links NVARCHAR(1000),
    @Images NVARCHAR(1000)
AS
INSERT [dbo].[Resource] ([Links], [Images])
VALUES(@Links, @Images)
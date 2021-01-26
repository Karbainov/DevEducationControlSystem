CREATE PROCEDURE [dbo].[AddTags]
	@name nvarchar(30)
AS
  SET IDENTITY_INSERT [Tag] ON
  INSERT INTO [Tag] ([Name])
  VALUES (@name)


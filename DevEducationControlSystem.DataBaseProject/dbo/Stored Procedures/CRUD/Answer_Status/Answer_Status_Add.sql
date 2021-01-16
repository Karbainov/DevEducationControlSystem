CREATE PROCEDURE [dbo].[AnswerStatus_Add]
    @Name NVARCHAR(100)
AS
INSERT [dbo].[AnswerStatus] ([Name])
VALUES(@Name)